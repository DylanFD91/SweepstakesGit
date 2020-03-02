using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UserInterface
    {
        public static string GetContestantFirstName()
        {
            Console.WriteLine("What is the First Name? ");
            string firstn = Console.ReadLine();
            return firstn;
        }
        public static string GetContestantLastName()
        {
            Console.WriteLine("What is the Last Name? ");
            string lastn = Console.ReadLine();
            return lastn;
        }
        public static string GetContestantEmailAddress()
        {
            Console.WriteLine("What is the Email Address? ");
            string emailn = Console.ReadLine();
            return emailn;
        }
    }
}
