using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.Consumer
{
   public class OrderProcessMessage: MQ.IProcessMessage
    {
        public void ProcessMsg(MQ.Message msg)
        {
            Console.WriteLine(msg.MessageBody);
        }
    }
}
