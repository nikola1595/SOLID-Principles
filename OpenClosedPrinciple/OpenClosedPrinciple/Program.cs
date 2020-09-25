using OCPLibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class Program
    {
        // [0] Object should be opened for extension, but closed for modification.
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new FrontEndDeveloperModel { FirstName = "Petar", LastName = "Perovic"},
                new ArtistModel {FirstName = "Zorana", LastName = "Zoric"},
                new BackEndDeveloperModel {FirstName = "Marko", LastName = "Markovic"},
                new FullStackDeveloperModel {FirstName = "John", LastName = "Doe"},

            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            

            foreach (var person in applicants)
            {
                employees.Add(person.AccountType.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}" +
                    $"| Email address:  {emp.EmailAddress} |" +
                    $" Is front end:  {emp.IsFrontEndDev} " +
                    $"| Is back end : {emp.IsBackEndDev} " +
                    $"| Is artist: {emp.IsArtist}");
                Console.WriteLine("\n");
            }

            Console.ReadLine();

        }
    }
}
