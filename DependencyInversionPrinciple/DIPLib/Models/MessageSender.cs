using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLib
{
    public class MessageSender : IMessageSender
    {
        public void SendMessageOrder(ICart cart, string message)
        {
            Console.WriteLine($"Cart number {cart.CartID} is approaching counter");
        }


        public void SendMessageFree(ICart cart, string message)
        {
            Console.WriteLine($"Cart number {cart.CartID} has left the counter");
        }

    }
}
