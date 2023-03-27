using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_Petra_Vida
{
    public class Parity
    {
        public void EvenOrOdd()
        {
            Console.Clear();
            Console.WriteLine("Enter some number: ");
            int choosenNumber = int.Parse(Console.ReadLine());
            if ( choosenNumber % 2 == 0)
            {
                Console.WriteLine($"Your choosen number {choosenNumber} is even.");
            }
            else
            {
                Console.WriteLine($"Your choosen number {choosenNumber} is odd.");
            }
            Console.ReadLine();
        }
    }
}
