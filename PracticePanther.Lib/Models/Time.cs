using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePanther.Lib.Models
{
    public class Time
    {
        public DateTime Date {get; set;}

        public string Narrative { get; set;}

        public int Hours { get; set;}

        public int EmployeeId { get; set; }

    }
}
