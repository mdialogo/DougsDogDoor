using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DougsDogDoor
{
    public class BarkRecognizer
    {
        private DogDoor dogDoor;

        public BarkRecognizer(DogDoor dogDoor)
        {
            this.dogDoor = dogDoor;
        }

        public void Recognize(Bark bark)
        {
            Console.WriteLine("\tBark recognizer heard a {0}\n", bark);
            foreach (var allowedBark in dogDoor.AllowedBarks)
            {
                if (allowedBark.Equals(bark))
                {
                    dogDoor.Open();
                    return;
                }
            }
            Console.WriteLine("This dog is not allowed!");
        }
    }
}
