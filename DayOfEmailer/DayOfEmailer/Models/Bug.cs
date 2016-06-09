using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DayOfEmailer.Models
{
    public class Bug
    {
        public int Id { get; set; }

        public bool IsCleared { get; set; }

        public int StatusCode { get; set; }

        public string User { get; set; }

        public string Message { get; set; }

        public string Detail { get; set; }

        public DateTime Time { get; set; }

        public IDictionary<string, string> Form { get; set; }

        public IDictionary<string, string> QueryString { get; set; }

        public IDictionary Data { get; set; }
    }
}