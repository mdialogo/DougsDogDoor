using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace DougsDogDoor
{
    public class Remote
    {
        private DogDoor door;
        private Timer timer;

        public Remote(DogDoor door)
        {
            this.door = door;
            this.timer = new Timer(5000);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (door.IsOpen())
                door.Close();
            else
            {
                door.Open();
                timer.Start();
            }
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.door.Close();
            timer.Stop();
        }
    }
}
