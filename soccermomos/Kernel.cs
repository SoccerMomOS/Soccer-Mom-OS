using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;

namespace soccermomos
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            static void beep()
            {
                Cosmos.System.PCSpeaker.Beep();
                Thread.Sleep(1);
            }

            Console.Write("SMOS: Makes Life Easy, so you can run a redlight while taking timmy to practice. If you hear 5 beeps, your a cool soccer mom");
            beep();
            beep();
            beep();
            beep();
            beep();
        }

        protected override void Run()
        {
            Console.Write("SMOS>>>");
            var input = Console.ReadLine();
        }
    }
}
