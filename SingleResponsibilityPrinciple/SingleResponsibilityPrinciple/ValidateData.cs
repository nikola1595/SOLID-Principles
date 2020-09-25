using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class ValidateData
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.firstName))
            {
                StandardMessages.DisplayValidatonError("first name");
                StandardMessages.EndApplication();
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.lastName))
            {
                StandardMessages.DisplayValidatonError("last name");
                StandardMessages.EndApplication();
                return false;
            }

            return true;

        }
            
    }
}
