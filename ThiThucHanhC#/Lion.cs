using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
   class Lion : Animal
    {
        public Lion(int Weight, string Name)
        { 
            this.Name = Name;
            this.Weight = Weight;
        }
        public override void Show()
        {
            Console.WriteLine("Name: " + Name + ", Weight: "+ Weight);
        }
    }
}
