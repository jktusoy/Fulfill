using Fulfill_RepositoryService.DomainEntities.System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Fulfill_RepositoryService.DomainEntities
{
    public class Task: CoreEntity
    {
       
        public Guid TaskId { get; set; }
        public string TaskName { get; set; }
        public string Category { get; set; }

        public List<Label> Labels { get; set; }

         

        public bool IsRecurring { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsActive { get; set; }

        public bool IsReplicated { get; set; }
        public Guid? ReplicationSource { get; set; }

        public Guid? PriorityId { get; set; }
        public Priority Priority { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

        public bool HasSubTaks { get; set; }
        public List<Reminder> Reminders { get; set; }
        public decimal Progress { get; set; } = 0;

        public string WorkFlowStatus { get; set; }
        public Guid WorkFlowStatusCode { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime DateCompleted { get; set; }

        public List<Task> SubTasks { get; set; }
        public List<Attachment> Attachments { get; set; }

    }


}
