using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_Petra_Vida
{
    public class MathematicalFunctions
    {
        public void QuadraticEquation()
        {
            Console.Clear();
            Console.WriteLine("Enter 3 numbers: ");
            double a = Int32.Parse(Console.ReadLine());
            double b = Int32.Parse(Console.ReadLine());
            double c = Int32.Parse(Console.ReadLine());
            double sqrtpart = b * b - 4 * a * c;
            double x, x1, x2, imgPart;
            if (sqrtpart > 0)
            {
                x1 = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine($"Your results are: {x1}, {x2}");
            }
            else if (sqrtpart < 0)
            {
                {
                    sqrtpart = -sqrtpart;
                    x = -b / (2 * a);
                    imgPart = Math.Sqrt(sqrtpart) / (2 * a);
                    Console.WriteLine($"Your results are: {x} + {imgPart} i, {x} + {imgPart} i");
                }
            }
            else
            {
                x = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine($"Your result is: {x}");
            }

            Console.ReadLine();
        }
        public void Average()
        {
            Console.Clear();
            List<int> listOfGrades = new List<int>();

            string exit = "0";
            do
            {
                Console.WriteLine("Enter grades for student: ");

                int grade = Int32.Parse(Console.ReadLine());
                listOfGrades.Add(grade);
                Console.WriteLine("To finish press 0 or press any other key to continue."); 
                exit = Console.ReadLine();
                int sum = listOfGrades.Sum();
                int avarage = sum / grade;
            }
            while (exit != "0");
            foreach (int grade in listOfGrades)
            {
                
            }


            Console.ReadLine();
        }

    }
}
