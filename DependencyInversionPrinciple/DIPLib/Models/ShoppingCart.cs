using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLib
{
    public class ShoppingCart : IShoppingCart
    {
        private ILogger _logger;
        private IMessageSender _messageSender;

        private List<ICart> _shoppingCart;
        public ICart Cart { get; set; }
        public ShoppingCart(ILogger logger, IMessageSender message)
        {
            _logger = logger;
            _messageSender = message;
            _shoppingCart = new List<ICart>();
        }

        public void AddContentToCart(ICart Cart)
        {
            _shoppingCart.Add(Cart);
        }


       
    }
}
