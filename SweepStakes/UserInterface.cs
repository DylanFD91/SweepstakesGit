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
            Console.WriteLine("What is your First Name? ");
            string firstn = Console.ReadLine();
            return firstn;
        }
        public static string GetContestantLastName()
        {
            Console.WriteLine("What is your Last Name? ");
            string lastn = Console.ReadLine();
            return lastn;
        }
        public static string GetContestantEmailAddress()
        {
            Console.WriteLine("What is your Email Address? ");
            string emailn = Console.ReadLine();
            return emailn;
        }
        public static int GetContestantARegistrationNumber()
        {
            int regn = 0;
            regn++;
            return regn;
        }
    }
}
