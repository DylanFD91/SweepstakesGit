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
        int regnumber = 0;
        
        //Constructor
        public SweepStakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }

        //Methods
        public void RegisterContestant(Contestant contestant)
        {
            regnumber++;
            contestants.Add(regnumber, contestant);
        }
        Contestant PickWinner()
        {
            
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
