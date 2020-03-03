using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakes
    {
        //Members
        Dictionary<int, Contestant> contestants;
        int dictionarynumber = 0;
        
        //Constructor
        public SweepStakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }

        //Methods
        public void RegisterContestant(Contestant contestant)
        {
            dictionarynumber++;
            contestants.Add(dictionarynumber, contestant);
        }
        public Contestant PickWinner()
        {
            int randomDictionaryNumber;
            randomDictionaryNumber = new Random().Next(1, dictionarynumber);
            Contestant winner = contestants[randomDictionaryNumber];
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayText("Name: " + contestant.firstName + " " + contestant.lastName);
            UserInterface.DisplayText("Email: " + contestant.emailAddress);
            UserInterface.DisplayText("Registration number: " + contestant.registrationNumber);
        }
        public void NotifyAllContestants()
        {
            Contestant winningContestant = PickWinner();
            foreach (Contestant contestant in contestants.Values)
            {
                if (contestant == winningContestant)
                {
                    UserInterface.DisplayText("Congratulations on winning the Sweepstakes!");
                    PrintContestantInfo(winningContestant);
                }
                else
                {
                    UserInterface.DisplayText("Sorry but a different contestant has won, better luck next time!");
                }
            }
        }
    }
}
