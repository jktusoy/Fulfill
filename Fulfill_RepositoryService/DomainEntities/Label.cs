using System;
using System.Collections.Generic;
using System.Text;

namespace Fulfill_RepositoryService.DomainEntities
{
    public class Label
    {
        public Guid LabelId { get; set; }
        public string LabelName { get; set; }
        public string Description { get; set; }
        //add icon
    }
}
