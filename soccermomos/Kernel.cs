using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;
using System.IO;
using Cosmos.System.FileSystem.Listing;
using System.Linq;

namespace soccermomos
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear(); // Clears BSD boot output
            Console.Write("SMOS!!!!");

            Cosmos.System.FileSystem.FileSystem fileSystem; // Initiates a filesystem type

            Cosmos.System.Network.Config.DNSConfig DNSconfig;
            Cosmos.System.Network.Config.DNSConfig IPconfig;            // Network Config
            Cosmos.System.Network.Config.NetworkConfig networkConfig;

            Cosmos.System.KeyEvent keyEvent; // keyboard config event stuff
        }


        protected override void Run()
        {
            static void beep()
            {
                Cosmos.System.PCSpeaker.Beep();
                Thread.Sleep(1);
            }

            var directory_list = Directory.GetFiles(@"0:\"); // Directory list | Code stolen from cosmos

            List<string> files = new List<string>();
            foreach (var file in directory_list)    // detects all files and adds them to a list | since the os is light this shouldnt be an issue ruby
            {
                files.Add(file);
            }

            bool listEmpty = !files.Any(); // Checks if list is empty
            if (listEmpty)
            {
                Console.Write("SMOS: Makes Life Easy, so you can run a redlight while taking timmy to practice. If you hear 5 beeps, your a cool soccer mom | Running in liveCD");
                beep();
                beep();
                beep();
                beep();
                beep();
            } else
            {
                Console.Write("SMOS: Makes Life Easy, so you can run a redlight while taking timmy to practice. If you hear 5 beeps, your a cool soccer mom");
                beep();
                beep();
                beep();
                beep();
                beep();
            }
        }
    }
}
