using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePanther.Lib.Models
{
    public class Employee
    {
        private static int LastId = 0;

        Employee() { Name = string.Empty; Id = ++LastId; }
        public string Name { get; set; }
        public int Id { get; private set;}
        public float Rate { get; set; }

    }
}
