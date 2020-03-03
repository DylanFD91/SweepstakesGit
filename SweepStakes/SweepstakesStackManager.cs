using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //Members
        Stack<SweepStakes> stack;
        //Constructor
        public SweepstakesStackManager()
        {
            stack = new Stack<SweepStakes>();
        }

        //Methods
        public SweepStakes GetSweepStakes()
        {
            SweepStakes sweepStakes = stack.Pop();
            return sweepStakes;
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
    }
}
