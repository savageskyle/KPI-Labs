using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5semestr2.Wind_Instruments
{
    public class Wind_Instrument : MusicalInstrument
    {
        public int Sila_duni { get; set; }
        public Wind_Instrument(string name, int sila_duni) : base(name)
        {
            Sila_duni = sila_duni;
        }

        public override void MakeSound()
        {
            Console.WriteLine(Sila_duni>=5? "loudno dudish": "slaben'ko(");
        }
    }
}
