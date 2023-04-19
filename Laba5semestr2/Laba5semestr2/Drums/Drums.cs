using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5semestr2.Drums
{
    public class Drums: MusicalInstrument
    {
        public int Radius { get; set; }

        public Drums(int radius, string name): base(name)
        {
            Radius = radius;
        }
        public override void MakeSound()
        {
            Console.WriteLine("badum-tss");
        }

    }
}
