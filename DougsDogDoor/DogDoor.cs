using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace DougsDogDoor
{
    public class DogDoor
    {
        private bool isOpen;
        private Timer timer;
        public List<Bark> AllowedBarks { get; set; }

        public DogDoor()
        {
            this.isOpen = false;
            this.timer = new Timer(5000);
            this.AllowedBarks = new List<Bark>();
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Close();
            this.timer.Stop();
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.\n");
            this.isOpen = true;
            this.timer.Start();
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes.\n");
            this.isOpen = false;
        }

        public bool IsOpen()
        {
            return this.isOpen;
        }
    }
}
