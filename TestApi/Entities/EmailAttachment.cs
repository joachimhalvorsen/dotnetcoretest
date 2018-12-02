using System;
using System.Collections.Generic;

namespace TestApi.Entities
{
    public partial class EmailAttachment
    {
        public Guid Id { get; set; }
        public Guid EmailId { get; set; }
        public string Filename { get; set; }
        public byte[] Attachment { get; set; }

        public Email Email { get; set; }
    }
}
