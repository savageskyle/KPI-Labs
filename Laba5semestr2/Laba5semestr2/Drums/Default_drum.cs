using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5semestr2.Drums
{
    public class Default_drum : Drums
    {
        public string depth_of_sound = "so deep!";

        public Default_drum(int radius, string name) : base(radius, name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($" depth of sound: {depth_of_sound}");
        }

    }
}
