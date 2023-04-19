using Laba5semestr2.Drums;
using Laba5semestr2.Stringed_Instrument;
using Laba5semestr2.Wind_Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5semestr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MusicalInstrument> orchestra = new List<MusicalInstrument>();
            orchestra.Add(new Guitar("guitar_of_yaroslav", material_of_strings.nylon, type_of_guitar.electro));
            orchestra.Add(new Violin("violin_of_yaroslav", material_of_strings.metalic, 0));
            orchestra.Add(new Default_drum(40, "drums_of_yaroslav"));
            orchestra.Add(new Djembe(30, "djembe_of_yaroslav"));
            orchestra.Add(new Clarinet("clarinet_of_yaroslav", 6, 4));
            foreach(MusicalInstrument instrument in orchestra)
            {
                instrument.MakeSound();
            }
            Console.ReadKey();
        }
    }
}
