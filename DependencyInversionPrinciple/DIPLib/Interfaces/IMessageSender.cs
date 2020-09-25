using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLib
{
    public interface IMessageSender
    {
        void SendMessageOrder(ICart cart, string message);
        void SendMessageFree(ICart cart, string message);
    }
}
