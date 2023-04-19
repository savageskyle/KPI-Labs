using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5semestr2
{
    public abstract class MusicalInstrument
    {
        public string Name { get; set; }
        public MusicalInstrument(string name)
        {
            Name = name;
        }
        public abstract void MakeSound();
    }
}
