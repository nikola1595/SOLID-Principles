using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibary
{
    public class EmployeeModel
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public bool IsFrontEndDev { get; set; } = false;

        public bool IsBackEndDev { get; set; } = false;

        public bool IsArtist { get; set; } = false;
    }
}
