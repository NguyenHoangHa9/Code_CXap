using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class manage : Staff
    {
        private int level;
        public void Level()
        {
            Console.WriteLine("Nhap level: ");
            level = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowLevel()
        { Console.WriteLine("Level : " + level); }
    }
}
