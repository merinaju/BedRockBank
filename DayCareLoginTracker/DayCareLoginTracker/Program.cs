using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCareLoginTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Welcome to LittleImpressions DayCare********");
         string option = "";
            Parent parent;
            do
            {
                Console.WriteLine("1.Register a new student");
                Console.WriteLine("2.Parent Login");
                Console.WriteLine("3.Print StudentDetails");
                Console.WriteLine("0.Exit");
                switch(option)
                {
                    case "1":
                        parent = VerifyParent();
                        Console.WriteLine("Please enter the name of the student");
                        var name = Console.ReadLine();
                        Console.WriteLine("Please enter the age");
                        var age=int.Parse(Console.ReadLine());
                        
                        break;
                }






            }
            while (option != "0");

        }
        private static Parent VerifyParent()

        {
            Console.WriteLine("what is your email address");
            var emailaddress = Console.ReadLine();
            var parent = DayCare.FindParent(emailaddress);
            if (parent == null)
            {
                Console.WriteLine("Please enter the name of the Parent");
                var parentname = Console.ReadLine();
                Console.WriteLine("Please enter phone number");
                var phonenumber = Console.ReadLine();
                Console.WriteLine("Please enter the street address");
                var streetaddress = Console.ReadLine();
                parent = DayCare.CreateParent(parentname,phonenumber,streetaddress,emailaddress);
            }

            return parent;
        }
    }
}
