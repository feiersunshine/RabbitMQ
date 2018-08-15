using Founder.MQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Founder.Producer
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Message msg = new Message();
            msg.MessageID = "1";
            msg.MessageBody = DateTime.Now.ToString();
            msg.MessageTitle = "1";
            msg.MessageRouter = "pcm.notice.zhangsan";
            MQHelper.Publish(msg);
        }
    }
}