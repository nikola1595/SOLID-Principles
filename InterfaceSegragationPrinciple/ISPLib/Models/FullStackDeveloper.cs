using ISPLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLib.Models
{
    public class FullStackDeveloper : Developer, IFullStack
    {
        private IFrontEnd _front;
        private IBackEnd _back;


        public FullStackDeveloper(IFrontEnd front, IBackEnd back)
        {
            _front = front;
            _back = back;
        }


        public void BackEndProgramming()
        {
            _back.BackEndProgramming();
        }

        public void DesigningFrontEnd()
        {
            _front.DesigningFrontEnd();
        }

        public void FrontEndPrograming()
        {
            _front.FrontEndPrograming();
        }

        public void SoftwareTesting()
        {
            _back.SoftwareTesting();
        }
    }
}
