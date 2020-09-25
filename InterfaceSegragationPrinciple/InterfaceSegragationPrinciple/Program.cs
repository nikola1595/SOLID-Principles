using ISPLib.Interfaces;
using ISPLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragationPrinciple
{
    class Program
    {
        // [I] Client should not be forced to depend on interfaces they don't use
        //It's better to make alot of small interfaces then general one.

        static void Main(string[] args)
        {
            IBackEnd backEndDev = new BackEndDeveloper();

            backEndDev.FirstName = "John";
            backEndDev.LastName = "Doe";
            Console.WriteLine($"{backEndDev.FirstName} {backEndDev.LastName} - Back End Developer");
            backEndDev.BackEndProgramming();
            backEndDev.SoftwareTesting();

            

            IFrontEnd frontEndDev = new FrontEndDeveloper();
            frontEndDev.FirstName = "Suzan";
            frontEndDev.LastName = "Anders";
            Console.WriteLine($"\n{frontEndDev.FirstName} {frontEndDev.LastName} - Front End Developer");
            frontEndDev.DesigningFrontEnd();
            frontEndDev.FrontEndPrograming();
            


            IFullStack fullStackDev = new FullStackDeveloper(frontEndDev, backEndDev);

            fullStackDev.FirstName = "Michael";
            fullStackDev.LastName = "Sender";

            Console.WriteLine($"\n{fullStackDev.FirstName} {fullStackDev.LastName} - Full Stack Developer");
            fullStackDev.BackEndProgramming();
            fullStackDev.DesigningFrontEnd();
            fullStackDev.FrontEndPrograming();
            fullStackDev.SoftwareTesting();


            Console.ReadLine();


        }
    }
}
