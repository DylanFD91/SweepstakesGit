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
        Random rng;
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
            randomDictionaryNumber = new Random().Next(dictionarynumber);
            Contestant winner = contestants[randomDictionaryNumber];
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Name: " + contestant.firstName + " " + contestant.lastName);
            Console.WriteLine("Email: " + contestant.emailAddress);
            Console.WriteLine("Registration number: " + contestant.registrationNumber);
        }
    }
}
