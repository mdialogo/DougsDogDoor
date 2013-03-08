using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DougsDogDoor
{
    public class DogDoor
    {
        private bool open;

        public DogDoor()
        {
            this.open = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.\n");
            this.open = true;
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes.\n");
            this.open = false;
        }

        public bool IsOpen()
        {
            return this.open;
        }
    }
}
