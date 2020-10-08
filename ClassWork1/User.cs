using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork1
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        private static int lastId = 0;
        public User(string FirstName, string LastName, string Location)
        {
            this.Id =++lastId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Location = Location;
        }
        public void GetMessage(Message message)
        {
            Console.WriteLine($"\n\nSubject: {message.Title}\n\n{message.Content}");
        }
    }
}
