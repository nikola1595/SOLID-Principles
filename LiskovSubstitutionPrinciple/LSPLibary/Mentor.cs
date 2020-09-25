using LSPLibary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibary
{
    public class Mentor : Employee
    {

        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);

        }

        public void GenerateEvaluation(string firstName, string lastName)
        {
            Console.WriteLine($"Evaluation test for {firstName} {lastName} has started");
        }
    }
}
