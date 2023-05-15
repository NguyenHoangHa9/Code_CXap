using Ex1;
using System;

public class Program
{
    public static void Main()
    {
        const int maxAtoms = 10;
        Atom[] atoms = new Atom[maxAtoms];
        int count = 0;

        while (count < maxAtoms)
        {
            Console.WriteLine($"Enter information for atom {count + 1}:");

            Atom atom = new Atom();
            if (atom.Accept())
            {
                atoms[count] = atom;
                count++;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Atomic information:");
        Console.WriteLine("Atomic  Symbol Full Name       Atomic Weight");
        Console.WriteLine("number");
        Console.WriteLine("------  ------ -------------- -------------");

        foreach (Atom atom in atoms)
        {
            if (atom != null)
            {
                atom.Display();
            }
        }

        Console.ReadKey();
    }
}
