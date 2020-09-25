using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibary
{
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IAccounts AccountType { get; set; } = new Accounts();


    }
}
