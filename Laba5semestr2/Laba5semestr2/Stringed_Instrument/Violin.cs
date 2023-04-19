using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5semestr2.Stringed_Instrument
{
    public class Violin : Stringed_Instrument
    {
        public int Length_of_stick { get; set; }
        public Violin(string name, material_of_strings material,int length_of_stick ) : base(name, material)
        {
            Length_of_stick = length_of_stick;
        }
        public override void MakeSound()
        {            
            Console.WriteLine(Length_of_stick>1?"sounds just beatiful": "no sound(");
        }
    }
}
