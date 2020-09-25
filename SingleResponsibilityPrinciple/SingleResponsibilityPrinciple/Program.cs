using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        //[S] Organize everything to classes.
        //Class should only have single responsibility.
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person person  = PersonDataCapture.Capture();

            bool isPersonValid = ValidateData.Validate(person);

            if(isPersonValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }


            UserCreation.CreateUser(person);

            StandardMessages.EndApplication();
            

            
        }
    }
}
