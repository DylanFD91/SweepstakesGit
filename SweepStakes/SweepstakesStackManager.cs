﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //Members

        //Constructor
        public SweepstakesStackManager()
        {

        }

        //Methods
        public SweepStakes GetSweepStakes()
        {
            string name = Console.ReadLine();
            SweepStakes newSweepStakes = new SweepStakes(name);
            return newSweepStakes;
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {

        }
    }
}
