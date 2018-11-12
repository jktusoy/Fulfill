using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Fulfill_RepositoryService.DomainEntities.System;

namespace Fulfill_RepositoryService.DomainEntities
{
    public class Progress : CoreEntity
    {
  
        public Guid ProgressId { get; set; }
    }
}
