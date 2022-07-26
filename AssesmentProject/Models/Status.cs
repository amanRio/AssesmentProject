using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssesmentProject.Models
{
    public class Status
    {
        public int Number { get; set; }
        public string Message { get; set; }

        public Status(int number, string message)
        {
            Number = number;
            Message = message;
        }
    }
}