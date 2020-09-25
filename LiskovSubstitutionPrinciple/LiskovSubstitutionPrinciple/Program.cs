using LSPLibary;
using LSPLibary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        /*[L] Objects in a program should be replaceable with instances of their
        subtypes without altering the correctness of that program.*/
        static void Main(string[] args)
        {
            IManaged emp = new Employee();

            emp.FirstName = "John";
            emp.LastName = "Doe";
            emp.CalculatePerHourRate(4);

            IManaged mentor = new Mentor();

            mentor.FirstName = "Ana";
            mentor.LastName = "Marie";
            mentor.AssignManager(emp);
            mentor.CalculatePerHourRate(2);


            IManager dir = new Director();

            dir.FirstName = "Bob";
            dir.LastName = "Watson";
            dir.CalculatePerHourRate(6);
            dir.GeneratePerformanceReview(emp.FirstName, emp.LastName);
            dir.YellAtSomeone(emp.FirstName, emp.LastName);


            IManager dir2 = new Director();

            dir2.FirstName = "Tommy";
            dir2.LastName = dir.LastName;
            dir2.GeneratePerformanceReview(mentor.FirstName, mentor.LastName);
            dir2.YouDoneGood(mentor.FirstName, mentor.LastName);
            dir2.CalculatePerHourRate(6);
            


            Console.WriteLine($"\n{emp.FirstName}'s salary is ${emp.Salary} / per hour");
            Console.WriteLine($"{mentor.FirstName}'s salary is ${ mentor.Salary} / per hour");



            Console.ReadLine();
        }
    }
}
