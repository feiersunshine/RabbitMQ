using System;
using System.Configuration;
using EasyNetQ;

namespace Founder.MQ
{
    /// <summary>
    /// 消息服务器连接器
    /// </summary>
    public class BusBuilder
    {
        public static IBus CreateMessageBus()
        {
            // 消息服务器连接字符串
            var connectionString = ConfigurationManager.ConnectionStrings["RabbitMQ"].ConnectionString;
            //string connectionString = "host=127.0.0.1:5672;virtualHost=OrderQueue;username=guest;password=guest";
            string connString = connectionString;
            if (connString == null || connString == string.Empty)
            {
                throw new Exception("messageserver connection string is missing or empty");
            }
            
            return RabbitHutch.CreateBus(connString);
        }

       
    }

}