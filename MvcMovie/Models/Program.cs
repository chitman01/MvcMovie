using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LoginDBContext())
            {
                db.Logins.Add(new Login { Username = "admin01" });
                db.SaveChanges();

                foreach (var Username in db.Logins)
                {
                    Console.WriteLine(Username.Username);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}