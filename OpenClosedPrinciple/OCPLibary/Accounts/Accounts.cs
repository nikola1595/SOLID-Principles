using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibary
{
    public class Accounts : IAccounts
    {

        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel em = new EmployeeModel();

            em.FirstName = person.FirstName;
            em.LastName = person.LastName;
            em.EmailAddress = person.FirstName.Substring(0, 1) + person.LastName + "@dev.com";


            return em;
        }



    }
}
