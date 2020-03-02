using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant
    {
        //Members
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        //Constructor
        public Contestant()
        {
            firstName = UserInterface.GetContestantFirstName();
            lastName = UserInterface.GetContestantLastName();
            emailAddress = UserInterface.GetContestantEmailAddress();
            registrationNumber = UserInterface.GetContestantARegistrationNumber();
        }

        //Methods

    }
}
