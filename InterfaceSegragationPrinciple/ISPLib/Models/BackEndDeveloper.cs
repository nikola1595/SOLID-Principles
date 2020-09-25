using ISPLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLib.Models
{
    public class BackEndDeveloper : Developer, IBackEnd
    {


        public void BackEndProgramming()
        {
            Console.WriteLine("- Constructing back end functionalities");
        }

        public void SoftwareTesting()
        {
            Console.WriteLine("- Automated testing in Selenium");
        }
    }
}
