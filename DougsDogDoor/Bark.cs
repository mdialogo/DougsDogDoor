using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DougsDogDoor
{
    public class Bark
    {
        private string sound;

        public Bark(string sound)
        {
            this.sound = sound;
        }

        public override bool Equals(object obj)
        {
            if (obj != null || this.GetType() == obj.GetType())
                return this.sound == ((Bark)obj).sound;
            else
                return false;
        }

        public override string ToString()
        {
            return sound;
        }

        public override int GetHashCode()
        {
            return this.sound.GetHashCode(); ;
        }
    }
}
