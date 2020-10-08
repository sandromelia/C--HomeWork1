using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork1
{
    public class Message
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Message(string Title, string Content)
        {
            this.Title = Title;
            this.Content = Content;
        }
    }
}
