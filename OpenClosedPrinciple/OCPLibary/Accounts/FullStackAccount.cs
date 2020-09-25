﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibary
{
    public class FullStackAccount : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel employee = new EmployeeModel();

            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = person.FirstName.Substring(0, 1) + person.LastName + "@fulll_dev.com";


            employee.IsBackEndDev = true;
            employee.IsFrontEndDev = true;

            return employee;
        }   
    }
}
