using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace ClassWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> Users = new List<User>() { 
                new User("Lionel", "Messi", "Barcelona"),
                new User("Cristiano", "Ronaldo", "Turin"),
                new User("Zlatan", "Ibrahimovic", "Milan")
            };
            
            foreach (var user in Users)
            {
                Console.WriteLine($"{user.Id}) {user.FirstName} {user.LastName} {user.Location}");
            }

            Console.WriteLine("Select User: ");
            var enteredId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Title: ");
            var enteredTitle = Console.ReadLine();
            Console.WriteLine("Description: ");
            var enteredContent = Console.ReadLine();
            Post.SendMessage(Users.FirstOrDefault(i => i.Id == enteredId),new Message(enteredTitle, enteredContent));
        }
    }
}
