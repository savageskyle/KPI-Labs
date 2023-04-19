using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba5semestr2.Drums
{
    public class Djembe: Drums
    {
        public string depth_of_sound = "not so deep but very ancient(";

        public Djembe(int radius, string name) : base(radius, name)
        { 

        }

        public override void MakeSound()
        {
            Console.WriteLine($"depth_of_sound {depth_of_sound}");
        }
    }
}
