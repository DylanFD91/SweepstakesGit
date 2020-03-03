using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        //Members
        public ISweepstakesManager management;

        //Constructor
        public MarketingFirm(ISweepstakesManager management)
        {
            this.management = management;
        }
        //Methods
        public void CreateSweepstakes()
        {
            SweepStakes sweepStakes = new SweepStakes("Random Sweepstakes");
        }
    }
}
