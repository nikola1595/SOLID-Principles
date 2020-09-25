using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibary
{
    public class ArtistAccount : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel emp = new EmployeeModel();

            emp.FirstName = person.FirstName;
            emp.LastName = person.LastName;
            emp.EmailAddress = person.FirstName.Substring(0, 1) + person.LastName + "@art_dev.com";

            emp.IsArtist = true;


            return emp;
        }
    }
}
