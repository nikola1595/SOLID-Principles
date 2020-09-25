using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibary.Interfaces
{
   public interface IManager : IEmployee
   {
        void GeneratePerformanceReview(string firstName, string lastName);

        void YellAtSomeone(string firstName, string lastName);

        void YouDoneGood(string firstName, string lastName);

   }
}
