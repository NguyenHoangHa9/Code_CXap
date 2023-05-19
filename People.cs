using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class People
    {
        private int id;
        private string name;
        private string email;
       

       public void people ()
                           
        {
            Console.Write("Nhap id:" );
            id = Convert.ToInt32(Console.ReadLine());
          
            Console.Write("Nhap ten:" );
            name = Console.ReadLine();
            
            Console.Write("Nhap email:");
            email = Console.ReadLine();
        }
        public void ShowInfor ()
        {
            Console.WriteLine("ID la: " + id);
            Console.WriteLine("Ten la: " +  name);
            Console.WriteLine("Email la: " +  email);
        }
        static void Main(string[] args)
        {
            manage objManage = new manage();
            objManage.people();
            objManage.staff();
            objManage.Level();
            objManage.ShowLevel();
            objManage.ShowInfor();
            objManage.ShowSalary();

            Console.ReadLine();

        }
    }
}
