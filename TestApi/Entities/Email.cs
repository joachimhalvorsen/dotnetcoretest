using System;
using System.Collections.Generic;

namespace TestApi.Entities
{
    public partial class Email
    {
        public Email()
        {
            EmailAttachment = new HashSet<EmailAttachment>();
        }

        public Guid Id { get; set; }
        public string SenderEmail { get; set; }
        public string RecipientEmail { get; set; }
        public string Title { get; set; }
        public string BodyHtml { get; set; }

        public ICollection<EmailAttachment> EmailAttachment { get; set; }
    }
}
