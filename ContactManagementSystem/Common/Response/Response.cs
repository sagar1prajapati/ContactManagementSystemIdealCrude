using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem.Common.Response
{
    public class Response
    {
        public Message SuccessMessage(string Message)
        {
            Message message = new Message();
            message.status = 1;
            message.result = Message;
            return message;
        }
        public Message FailMessage(string Message)
        {
            Message message = new Message();
            message.status = 0;
            message.result = Message;
            return message;
        }
    }
}
