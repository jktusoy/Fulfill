using System;
using System.ComponentModel.DataAnnotations;

namespace Fulfill_RepositoryService.DomainEntities
{
    public class Attachment
    {
        [Key]
        public Guid AttachmentId { get; set; }
    }
}