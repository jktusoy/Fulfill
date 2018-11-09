using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fulfill_RepositoryService.EntityService
{
    public class FulfillContext : DbContext
    {
        private readonly string AppUser = "FulfillService";

        public FulfillContext() : base("name=fulfillConnection")
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Database.SetInitializer<FulfillContext>(null);
            base.OnModelCreating(modelBuilder);
   
        }


    }
}
