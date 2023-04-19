using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5semestr2.Wind_Instruments
{
    public class Clarinet : Wind_Instrument
    {
        public int Lenght { get; set; }
        public Clarinet(string name, int sila_duni, int length) : base(name, sila_duni)
        {
            Lenght = length;
        }
        public override void MakeSound()
        {
            base.MakeSound();
        }

    }
}
