using Ex1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Staff : People
{
    private double salary;
    
    public void staff()
    {
        Console.WriteLine("Nhap muc luong :" );
        salary = Convert.ToDouble( Console.ReadLine() );
     
    }
    public void ShowSalary()
    {
        Console.WriteLine("Muc luong la: " +  salary);
    }
}