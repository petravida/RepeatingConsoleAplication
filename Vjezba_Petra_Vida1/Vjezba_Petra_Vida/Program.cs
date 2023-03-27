using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_Petra_Vida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Even or odd?");
            Console.WriteLine("2) Quadratic Equation: ");
            Console.WriteLine("3) Average: ");
            Console.WriteLine("4) Adding the last digits: ");
            Console.WriteLine("5) Let's play LOTO: ");
            Console.WriteLine("6) Creating Leaflet: ");
            Console.WriteLine("7) Person Program: ");
            Console.WriteLine("8) Making PDF: ");

            int results = Int32.Parse(Console.ReadLine());
            switch (results)
            {
                case 1:
                    Parity firstCase = new Parity();
                    firstCase.EvenOrOdd();
                    break;
                case 2:
                    MathematicalFunctions secondCase = new MathematicalFunctions();
                    secondCase.QuadraticEquation();
                    break;
                case 3:
                    MathematicalFunctions thirdCase = new MathematicalFunctions();
                    thirdCase.Average();
                    break;
                case 4:
                    break;
                case 5:
                    LOTOFunctions fifthCase = new LOTOFunctions();
                    fifthCase.RendomNumber();
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                default:
                    break;
            };
            Console.ReadLine();
            

        }
        

    }
}
