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
        
        public bool IsRecurring { get; set; }
        public bool IsCompleted { get; set; }

        private List<Schedule> RemindSchedules { get; set; }
        //snooze

    }
}
