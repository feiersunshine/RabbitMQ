using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Founder.MQ
{
    public interface IProcessMessage
    {
        void ProcessMsg(Message msg);
    }
}