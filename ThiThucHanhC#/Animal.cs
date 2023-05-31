using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Animal
    {
        protected string Name;
        protected int Weight;
        public void Setme(int Weight, string Name)
        {
            this.Weight = Weight;
            this.Name = Name;
        }
        public virtual void Show()
        {
            Console.WriteLine("Name: " +  Name + " , Weight: " + Weight);
        }
    }
    

}
