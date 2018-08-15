using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founder.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessMessage order = new OrderProcessMessage();
            MQ.Message msg = new MQ.Message();
            msg.MessageID = "1";
            msg.MessageRouter = "pcm.notice.zhangsan";
            MQ.MQHelper.Subscribe(msg, order);
            Console.WriteLine("Listening for messages.");
        }

    }
}
