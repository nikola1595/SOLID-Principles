using ISPLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLib.Models
{
    public class Developer : IDeveloper
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
