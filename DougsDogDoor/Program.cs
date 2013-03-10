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
            door.AllowedBarks.Add(new Bark("rowlf"));
            door.AllowedBarks.Add(new Bark("roowlf"));
            door.AllowedBarks.Add(new Bark("rawlf"));
            door.AllowedBarks.Add(new Bark("woof"));

            Remote remote = new Remote(door);
            BarkRecognizer recognizer = new BarkRecognizer(door);

            Console.WriteLine("Scenario #1");
            Console.WriteLine("Bruce barks to go outside...");
            remote.PressButton();
            Console.WriteLine("Bruce has gone outside...");
            Console.WriteLine("Bruce's all done...");
            Console.WriteLine("Bruce's back inside");
            Console.ReadLine();

            Console.WriteLine("Scenario #2");
            Console.WriteLine("\nFido barks to go outside...");
            remote.PressButton();
            Console.WriteLine("Bruce has gone outside...");
            Thread.Sleep(6000);

            Console.WriteLine("Bruce's all done...");
            Console.WriteLine("But he's stuck outside!");
            Console.WriteLine("Bruce starts barking...");
            Console.WriteLine("...so Gina grabs the remote control button...");
            remote.PressButton();
            Console.WriteLine("Bruce's back inside");
            Console.ReadLine();

            Console.WriteLine("Scenario #3");
            Console.WriteLine("Bruce starts barking.");
            recognizer.Recognize(new Bark("woof"));
            Console.WriteLine("Bruce has gone outside");
            Thread.Sleep(6000);

            //simulate the hardware hearing a bark (not Bruce!)
            Bark otherDogBark = new Bark("yip");
            Console.WriteLine("A small dog starts barking...");
            recognizer.Recognize(otherDogBark);
            Thread.Sleep(5000);

            otherDogBark = new Bark("aw aw");
            Console.WriteLine("A big dog starts barking...");
            recognizer.Recognize(otherDogBark);
            Thread.Sleep(5000);

            otherDogBark = new Bark("awooo");
            Console.WriteLine("A wolf dog starts barking...");
            recognizer.Recognize(otherDogBark);
            Thread.Sleep(5000);

            Console.WriteLine("Bruce's all done.");
            Console.WriteLine("Bruce starts barking...");
            recognizer.Recognize(new Bark("roowlf"));
            Console.WriteLine("Bruce's back inside.");
            Console.ReadLine();
        }
    }
}
