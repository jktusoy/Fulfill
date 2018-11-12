using System;
using System.Collections.Generic;
using System.Text;
using Fulfill_RepositoryService.DomainEntities.System;

namespace Fulfill_RepositoryService.DomainEntities
{
    public class Reminder : CoreEntity
    {
        public Guid ReminderId { get; set; }
        public string ReminderName { get; set; }
        
    }
}
