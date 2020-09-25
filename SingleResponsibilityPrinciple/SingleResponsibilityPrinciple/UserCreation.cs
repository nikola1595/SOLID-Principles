using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class UserCreation
    {
        public static void CreateUser(Person user)
        {
            Console.WriteLine("\nUser  Created");
            Console.WriteLine($"Hello, {user.firstName.Substring(0,1)}{user.lastName}");
        }
    }
}
