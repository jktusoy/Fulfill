using System;
using System.Collections.Generic;
using System.Text;

namespace Fulfill_RepositoryService.DomainEntities
{
    public class Category
    {
        public string CategoryName { get; set; }
         public Category ParentCategory { get; set; }
        public List<Category> SubCategories { get; set; }
    }
}
