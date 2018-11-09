using System;
using System.ComponentModel.DataAnnotations;

namespace Fulfill_RepositoryService.DomainEntities.System
{
    public abstract class CoreEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Description { get; set; }
    }
}
