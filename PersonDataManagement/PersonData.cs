using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDataManagement
{
    public class PersonData
    {
        public static List<Person> list = new List<Person>();
        public void AddPersonData(List<Person> list)
        {
            Person person = new Person();
            Console.WriteLine("Enter SSN: ");
            person.SSN = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            person.Name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            person.Address = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            person.Age = Convert.ToInt16(Console.ReadLine());
            list.Add(person);
            Console.WriteLine("Data Added");
        }
        public void Display(List<Person> list)
        {
            foreach (Person data in list)
            {
                Console.WriteLine("SSN is :" + data.SSN);
                Console.WriteLine("Name :" + data.Name);
                Console.WriteLine("Address :" + data.Address);
                Console.WriteLine("Age :" + data.Age);
            }
        }
        public void DataManagement()
        {
            int choice;
            Console.WriteLine("\n1. for inserting record\n2. for display the record");
            Console.WriteLine("Enter Your choice");
            choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddPersonData(list);
                    break;
                case 2:
                    Display(list);
                    break;
                default:
                    Console.WriteLine("Oops you enter wrong input.. try again...");
                    break;

            }

        }
    }
}
