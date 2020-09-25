using LSPLibary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibary
{
    public class Director : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;

        }


        public void GeneratePerformanceReview(string firstName, string lastName)
        {
            Console.WriteLine($"Reviewing evaluation report for {firstName} {lastName}...");
        }

        public void YellAtSomeone(string firstName, string lastName)
        {
            Console.WriteLine($"Director just shouted at {firstName} {lastName} ");
        }


        public void YouDoneGood(string firstName, string lastName)
        {
            Console.WriteLine($"Director values effort from {firstName} {lastName}");
        }

    }
}
