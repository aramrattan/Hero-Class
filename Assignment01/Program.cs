using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            string consoleKey = "";
            Hero Xena = new Hero("Xena");
            Xena.show();

            //used to check if all features are working as should
            while (consoleKey != "q")
            {
                Xena.fight();
                consoleKey = Console.ReadLine();
            }
        }
    }
}
