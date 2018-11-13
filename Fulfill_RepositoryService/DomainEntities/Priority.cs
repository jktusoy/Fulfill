using System;
using System.ComponentModel.DataAnnotations;
using Fulfill_RepositoryService.DomainEntities.System;

namespace Fulfill_RepositoryService.DomainEntities
{
    public class Priority : CoreEntity
    {
 
        public Guid PriorityId { get; set; }
        public decimal Merit { get; set; }

    }
}