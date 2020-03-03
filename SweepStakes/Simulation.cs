using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Simulation
    {
        //Members
        //Constructor
        public Simulation()
        {

        }
        public string GetInput()
        {
            string input = Console.ReadLine().ToLower();
            return input;
        }
        public void RunSim()
        {
            ISweepstakesManager sweepstakesChoice = ManagerFactory.Factory(GetInput());
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesChoice);
        }
    }
}
