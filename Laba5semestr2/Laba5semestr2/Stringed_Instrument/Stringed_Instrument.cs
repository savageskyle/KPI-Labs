using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5semestr2.Stringed_Instrument
{
    public enum material_of_strings
    {
        nylon, metalic
    }
    public class Stringed_Instrument : MusicalInstrument
    {
        public int Amount_of_strings { get; set; }
        public material_of_strings material { get; set; }

        public Stringed_Instrument(string name, material_of_strings material) : base(name)
        {
            this.material = material;
        }

        public override void MakeSound()
        {
            Console.WriteLine( material==material_of_strings.nylon? "dang-dang-dang":"din-din-din");
        }
    }
}
