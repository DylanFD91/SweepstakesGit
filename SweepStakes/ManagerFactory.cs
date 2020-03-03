using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class ManagerFactory
    {
        public static ISweepstakesManager Factory(string input)
        {
            bool ssManagerChooser = false;
            ISweepstakesManager sweepstakes = null;
            while (ssManagerChooser == false)
            {
                switch (input)
                {
                    case "queue":
                        sweepstakes = new SweepstakesQueueManager();
                        ssManagerChooser = true;
                        break;
                    case "stack":
                        sweepstakes = new SweepstakesStackManager();
                        ssManagerChooser = true;
                        break;
                    default:
                        Console.WriteLine("Improper input try again...");
                        break;
                }
            }
            return sweepstakes;
        }
    }
}
