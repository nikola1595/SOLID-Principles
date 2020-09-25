using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLib
{
    public class Factory
    { 
        public static ICart GetCart()
        {
            return new Cart();
        }

        public static IShoppingCart AddContentToCart()
        {
            return new ShoppingCart(CreateLogger(),CreateMessage());
        }


        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessage()
        {
            return new MessageSender();
        }


        public static List<ICart> CartList()
        {
            return new List<ICart>();
        }
        




    }
}
