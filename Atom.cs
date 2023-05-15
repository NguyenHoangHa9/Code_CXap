using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Atom
    {
        public int AtomicNumber { get; set; }
        public string Symbol { get; set; }
        public string FullName { get; set; }
        public double AtomicWeight { get; set; }

        public bool Accept()
        {
            Console.Write("Nhập số nguyên tử : ");
            if (!int.TryParse(Console.ReadLine(), out int atomicNumber) || atomicNumber < 1) // 
            {
                Console.WriteLine("Invalid input for atomic number. Try again.");
                return false;
            }
            AtomicNumber = atomicNumber;

            Console.Write("Enter symbol: ");
            string symbol = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(symbol))
            {
                Console.WriteLine("Symbol cannot be empty. Try again.");
                return false;
            }
            Symbol = symbol;

            Console.Write("Enter full name: ");
            string fullName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine("Full name cannot be empty. Try again.");
                return false;
            }
            FullName = fullName;

            Console.Write("Enter atomic weight: ");
            if (!double.TryParse(Console.ReadLine(), out double atomicWeight) || atomicWeight <= 0)
            {
                Console.WriteLine("Invalid input for atomic weight. Try again.");
                return false;
            }
            AtomicWeight = atomicWeight;

            return true;
        }

        public void Display()
        {
            Console.WriteLine($"{AtomicNumber,-3} {Symbol,-3} {FullName,-15} {AtomicWeight,-10:F4}");
        }
    }
}
