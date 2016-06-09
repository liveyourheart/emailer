using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DayOfEmailer.Models
{
    public class Solicitation
    {
        public int Id { get; set; }

        public List<Recipient> Recipients { get; set; }

        public List<string> Attachments { get; set; }

        public List<string> BCC { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string Name { get; set; }

        public string FromName { get; set; }

        public bool Enabled { get; set; }

    }
}