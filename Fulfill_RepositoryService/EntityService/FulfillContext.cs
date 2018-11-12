using Fulfill_RepositoryService.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace Fulfill_RepositoryService.EntityService
{
    public class FulfillContext : DbContext
    {
        private readonly string AppUser = "FulfillService";

      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=fulfill;Integrated Security=True");
        }




        public DbSet<Task> Tasks { get; set; }
        public DbSet<Attachment> Attachment { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<Reminder> Reminders { get; set; }


    }
}
