using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Tiger : Animal
    {
        public Tiger(int Weight , string Name )
        {
            this.Weight = Weight;
            this.Name = Name;
        }
        public override void Show()
        {
            Console.WriteLine("Name: " + Name + ", Weight: " + Weight);
        }
    }
}
