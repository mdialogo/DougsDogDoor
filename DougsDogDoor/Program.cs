using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DougsDogDoor
{
    class Program
    {
        static void Main(string[] args)
        {
            //page #145 (requirements change)

            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Scenario #1");
            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();
            Console.WriteLine("Fido has gone outside...");
            Console.WriteLine("Fido's all done...");
            Console.WriteLine("Fido's back inside");
            Console.ReadLine();

            Console.WriteLine("Scenario #2");
            Console.WriteLine("\nFido barks to go outside...");
            remote.PressButton();
            Console.WriteLine("Fido has gone outside...");
            Thread.Sleep(6000);

            Console.WriteLine("Fido's all done...");
            Console.WriteLine("But he's stuck outside!");
            Console.WriteLine("Fido starts barking...");
            Console.WriteLine("...so Gina grabs the remote control button...");
            remote.PressButton();
            Console.WriteLine("Fido's back inside");
            Console.ReadLine();
        }
    }
}
