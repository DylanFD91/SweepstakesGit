using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    interface ISweepstakesManager
    {
        //Methods
        void InsertSweepstakes(SweepStakes sweepstakes);
        SweepStakes GetSweepStakes();
    }
}
