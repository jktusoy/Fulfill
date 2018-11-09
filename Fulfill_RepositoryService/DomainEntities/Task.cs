using Fulfill_RepositoryService.DomainEntities.System;
using System;
using System.Collections.Generic;


namespace Fulfill_RepositoryService.DomainEntities
{
    public class Task: CoreEntity
    {
        public string TaskName { get; set; }
        public string Category { get; set; }
        public List<Label> Labels { get; set; }
        public bool IsRecurring { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsReplicated { get; set; }
        public Guid? ReplicationSource { get; set; }

        public Guid? PriorityId { get; set; }
        public Priority Priority { get; set; }

        public bool HasSubTaks { get; set; }
        public List<Reminder> Reminders { get; set; }
        public decimal Progress { get; set; } = 0;
        public DateTime StartDate { get; set; }
        public DateTime DateCompleted { get; set; }
        public List<Task> SubTasks { get; set; }
        public List<Attachments> Attachments { get; set; }

    }


}
