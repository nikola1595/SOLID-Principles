using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DIPLib.Storage;

namespace DIPLib
{
    public class Cart : ICart
    { 
        public int CartID { get; set; }
        public Drinks  Drink{ get; set; }
        public Vegetables Vegetable { get; set; }
        public Fruits Fruit { get; set; }
    }
}
