using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibary
{
    public class BackEndAccount : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel emp = new EmployeeModel();

            emp.FirstName = person.FirstName;
            emp.LastName = person.LastName;
            emp.EmailAddress = person.FirstName.Substring(0, 1) + person.LastName + "@back_dev.com";

            emp.IsBackEndDev = true;

            return emp;
        }
    }
}
