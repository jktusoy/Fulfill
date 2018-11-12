using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Fulfill_RepositoryService.DomainEntities.System;

namespace Fulfill_RepositoryService.DomainEntities
{
    public class Label : CoreEntity
    {
       
        public Guid LabelId { get; set; }

        public string LabelName { get; set; }
        public string Description { get; set; }
        //add icon
    }
}
