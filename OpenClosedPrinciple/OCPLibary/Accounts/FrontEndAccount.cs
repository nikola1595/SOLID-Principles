using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OCPLibary
{
    public class FrontEndAccount : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {

            EmployeeModel em = new EmployeeModel();

            em.FirstName = person.FirstName;
            em.LastName = person.LastName;
            em.EmailAddress = person.FirstName.Substring(0, 1) + person.LastName + "@front_dev.com";

            em.IsFrontEndDev = true;

            return em;

        }
    }
}
