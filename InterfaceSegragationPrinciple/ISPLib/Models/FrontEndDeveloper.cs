using ISPLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLib.Models
{
    public class FrontEndDeveloper : Developer,IFrontEnd
    {

        public void DesigningFrontEnd()
        {
            Console.WriteLine("- Designing user interface");
        }

        public void FrontEndPrograming()
        {
            Console.WriteLine("- Using jQuery for front-end logic");
        }
    }
}
