using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork1
{
    public static class Post
    {
        public static void SendMessage(User ToUser, Message MyMessage)
        {
            ToUser.GetMessage(MyMessage);
        }
    }
}
