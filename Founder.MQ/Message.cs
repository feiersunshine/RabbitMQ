using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Founder.MQ
{
    public class Message
    {
        public string MessageID { get; set; }

        public string MessageTitle { get; set; }

        public string MessageBody { get; set; }

        public string MessageRouter { get; set; }
    }
}