using DIPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DIPLib.Storage;

namespace DependencyInversionPrinciple
{
    class Program
    {
        /*[D] High level modules should not depend on low level modules.
        Depending on apstractions not on concretions*/
        static void Main(string[] args)
        {
            ICart cart1 = Factory.GetCart();
            cart1.CartID = 1;
            cart1.Drink = Drinks.Beer;
            cart1.Fruit = Fruits.Grapes;
            cart1.Vegetable = Vegetables.Watermelon;

            ICart cart2 = Factory.GetCart();
            cart2.CartID = 2;
            cart2.Drink = Drinks.Coffee;
            cart2.Fruit = Fruits.Apple;
            cart2.Vegetable = Vegetables.Potato;


            IShoppingCart shoppingCart = Factory.AddContentToCart();
            shoppingCart.AddContentToCart(cart1);

            shoppingCart.AddContentToCart(cart2);

            List<ICart> shopCart = Factory.CartList();

            shopCart.Add(cart1);
            shopCart.Add(cart2);
            IMessageSender message = Factory.CreateMessage();

            foreach (var item in shopCart)
            {
                Console.WriteLine($"\nCart number: { item.CartID}");
                Console.WriteLine($"Drink: { item.Drink}");
                Console.WriteLine($"Fruit: { item.Fruit}");
                Console.WriteLine($"Vegetable: { item.Vegetable}");
                message.SendMessageOrder(item, $"Cart number: { item.CartID}");
                message.SendMessageFree(item, $"Cart number: {item.CartID}");
            }




            Console.ReadLine();



        }
    }
}
