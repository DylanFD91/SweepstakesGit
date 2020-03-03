using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UserInterface
    {
        public static string ContestantFirstName()
        {
            Console.WriteLine("What is the First Name? ");
            string firstn = Console.ReadLine();
            return firstn;
        }
        public static string ContestantLastName()
        {
            Console.WriteLine("What is the Last Name? ");
            string lastn = Console.ReadLine();
            return lastn;
        }
        public static string ContestantEmailAddress()
        {
            Console.WriteLine("What is the Email Address? ");
            string emailn = Console.ReadLine();
            return emailn;
        }
        public static void DisplayText(string message)
        {
            Console.WriteLine(message);
        }
        public static int ContestantRegistrationNumber()
        {
            int registrationNumber = 0;
            registrationNumber++;
            return registrationNumber;
        }
    }
}
