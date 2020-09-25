using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DIPLib.Storage;

namespace DIPLib
{
    public interface ICart
    {
        int CartID { get; set; }
        Fruits Fruit { get; set; }
        Vegetables Vegetable { get; set; }
        Drinks Drink { get; set; }
    }
}
