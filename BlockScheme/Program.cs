using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BlockScheme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User() { IsPremium = false, Login = "Petrov", Name = "Иван" }) ;
            users.Add(new User() { IsPremium = true, Login = "Sidorov", Name = "Алексей" });
            users.Add(new User() { IsPremium = true, Login = "Ivanov", Name = "Андрей" });


            foreach (User user in users)
            {
                Console.WriteLine("Здравствуйте {0}", user.Name);
                if(!user.IsPremium)
                {
                    User.ShowAds();
                }
            }

            Console.ReadKey(); 
        }
    }
}
