using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DayOfEmailer.Models
{
    public class Recipient
    {
        public int Id { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Must be valid Email")]
        public string Email { get; set; }

        public DateTime AnniversaryDate { get; set; }

        public DateTime? DateSent { get; set; }

        public IDictionary<string, string> Placeholders { get; set; }


    }
}