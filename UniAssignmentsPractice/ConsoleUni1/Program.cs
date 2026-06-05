using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUni1
{
    public class PersonDetails
    {
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Street { get; set; }
        public int Postcode { get; set; }
        public string City { get; set; }
        public string Designation { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            VisitingCardCreator card = new VisitingCardCreator();
            PersonDetails person = new PersonDetails();
            // Intro Message
            Console.WriteLine("*****Welcome to Gotham’s Best Visiting Card Maker*****");
            Console.WriteLine("Please provide your details so that we can design your visit card:");

            // Data Input
            Console.Write("Your Name: ");
            person.Name = Console.ReadLine();
            Console.Write("DOB(dd-mm-yyyy): ");
            person.Dob = DateTime.Parse(Console.ReadLine());
            Console.Write("Street Address: ");
            person.Street = Console.ReadLine();
            Console.Write("PostCode: ");
            person.Postcode = int.Parse(Console.ReadLine());
            Console.Write("City: ");
            person.City = Console.ReadLine();
            Console.Write("Your Specialty: ");
            person.Designation = Console.ReadLine();
            // Data Output
            card.PrintVisitingCard(person);
            // StreamWriter
            using (StreamWriter sw = new StreamWriter("..\\..\\..\\persondetails.csv", true))
            {
                if (!File.Exists("..\\..\\..\\persondetails.csv"))
                {
                    sw.WriteLine("Name;Dob;Street;Postcode;City;Designation");
                }
                sw.WriteLine($"{person.Name};{person.Dob.ToShortDateString()};{person.Street};{person.Postcode};{person.City};{person.Designation}");
            }
        }
        class VisitingCardCreator
        {
            public void PrintVisitingCard(PersonDetails person)
            {


                // Data Output
                Console.WriteLine($"Name: {person.Name}");
                Console.WriteLine($"DOB: {person.Dob}");
                Console.WriteLine($"Street: {person.Street}");
                Console.WriteLine($"PostCode: {person.Postcode}");
                Console.WriteLine($"City: {person.City}");
                Console.WriteLine($"Designation: {person.Designation}");
                Console.ReadKey();
            }
        }
    }
}