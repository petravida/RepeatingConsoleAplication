using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_Petra_Vida
{
    public class Person
    {
        public string FirstName { get; set; }    
        public string LastName { get; set; }    
        public DateTime DOB { get; set; }   
        public char SEX { get; set; }

        public void EnterPerson()
        {
            Console.Clear();
            List<Person> listOfPersons = new List<Person>();
            string answer;
            do
            {
                Person newPerson = new Person();
                Console.WriteLine("Enter first name: ");
                newPerson.FirstName = Console.ReadLine();
                Console.WriteLine("Enter last name: ");
                newPerson.LastName = Console.ReadLine();
                Console.WriteLine("Enter date of birth: ");
                newPerson.DOB = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter sex (M/F): ");
                newPerson.SEX = char.Parse(Console.ReadLine());
                listOfPersons.Add(newPerson);
                Console.WriteLine("Do you want to enter new person? (Y/N)");
                answer = Console.ReadLine();
            }
            while (answer == "Y");
            //Person personOne = new Person();
            //Console.WriteLine("Enter first name for first person: ");
            //personOne.FirstName = Console.ReadLine();
            //Console.WriteLine("Enter last name for first person: ");
            //personOne.LastName = Console.ReadLine();
            //Console.WriteLine("Enter date of birth for first person: ");
            //personOne.DOB = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Enter sex for first person (M/F): ");
            //personOne.SEX = char.Parse(Console.ReadLine());

            //Person personTwo = new Person();
            //Console.WriteLine("Enter first name for second person: ");
            //personTwo.FirstName = Console.ReadLine();
            //Console.WriteLine("Enter last name for second person: ");
            //personTwo.LastName = Console.ReadLine();
            //Console.WriteLine("Enter date of birth for second person: ");
            //personTwo.DOB = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Enter sex for second person (M/F): ");
            //personTwo.SEX = char.Parse(Console.ReadLine());

            //Person personThree = new Person();
            //Console.WriteLine("Enter first name for third person: ");
            //personThree.FirstName = Console.ReadLine();
            //Console.WriteLine("Enter last name for third person: ");
            //personThree.LastName = Console.ReadLine();
            //Console.WriteLine("Enter date of birth for third person: ");
            //personThree.DOB = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Enter sex for third person (M/F): ");
            //personThree.SEX = char.Parse(Console.ReadLine());

            //Person personFour = new Person();
            //Console.WriteLine("Enter first name for fourth person: ");
            //personFour.FirstName = Console.ReadLine();
            //Console.WriteLine("Enter last name for fourth person: ");
            //personFour.LastName = Console.ReadLine();
            //Console.WriteLine("Enter date of birth for fourth person: ");
            //personFour.DOB = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Enter sex for fourth person (M/F): ");
            //personFour.SEX = char.Parse(Console.ReadLine());

            int totalMales = listOfPersons.Count(person => person.SEX == 'M');

            Console.ReadLine();
        }

    }
   

    


}
