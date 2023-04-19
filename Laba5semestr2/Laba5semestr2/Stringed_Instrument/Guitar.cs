using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5semestr2.Stringed_Instrument
{
    public enum type_of_guitar
    {
        electro, acoustic
    }
    public class Guitar : Stringed_Instrument
    {
        public type_of_guitar Type_of_guitar { get; set; }

        public Guitar(string name, material_of_strings material, type_of_guitar electro_acoustic) : base(name, material)
        {
            Type_of_guitar = electro_acoustic;
        }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine(Type_of_guitar == type_of_guitar.electro ? "...wjwjwjwj":"....blimblimblim" ) ;
        }
    }
}
