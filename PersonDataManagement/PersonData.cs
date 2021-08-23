using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonDataManagement
{
    public class PersonData
    {
        public static int Choice;
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
        public void DisplayTopTwoBelow60(List<Person> list)
        {
            var persons = list.Where(x => x.Age < 60).Take(2);
            Console.WriteLine("");
            foreach (var items in persons)
            {
                Console.WriteLine("SSN :" + items.SSN);
                Console.WriteLine("Name :" + items.Name);
                Console.WriteLine("Address :" + items.Address);
                Console.WriteLine("Age :" + items.Age + "\n");
            }
        }
        public void DisplayAgeBetween13And18(List<Person> list)
        {
            var persons = list.Where(x => x.Age > 13 && x.Age < 18);
            Console.WriteLine("Displaying age between 13 and 18.");
            foreach (var items in persons)
            {
                Console.WriteLine("SSN :" + items.SSN);
                Console.WriteLine("Name :" + items.Name);
                Console.WriteLine("Address :" + items.Address);
                Console.WriteLine("Age :" + items.Age+"\n");
            }
        }
        public void AverageAge(List<Person> list)
        {
            double average = list.Average(p => p.Age);
            Console.WriteLine("Average is : "+average);
        }
        public void Check(List<Person> list)
        {
            Console.WriteLine("Enter a person Name to check");
            string name = Console.ReadLine();
            var data = list.Any(x => x.Name.Equals(name));
            if (data==true)
                Console.WriteLine(name + " : is present in list");
            else
                Console.WriteLine(name + " : is not present in list");
        }
        public void SkipBelow60(List<Person> list)
        {
            var persons = list.Where(x => x.Age > 60);
            Console.WriteLine("");
            foreach (var items in persons)
            {
                Console.WriteLine("SSN :" + items.SSN);
                Console.WriteLine("Name :" + items.Name);
                Console.WriteLine("Address :" + items.Address);
                Console.WriteLine("Age :" + items.Age + "\n");
            }
        }
        public void Remove(List<Person> list)
        {
            Console.WriteLine("Enter a Person name:");
            string name = Console.ReadLine();
            var data = list.Where(x => x.Name.Equals(name));
            if (data==null)
            {
                Console.WriteLine("Name is not present in list");
            }
            foreach (var item in data.ToArray())
            {
                list.Remove(item);
            }
             
        }
        public void DataManagement()
        {
            while (Choice != 10)
            {
                Console.WriteLine("\n1. for inserting record\n2. for display the record\n3. for display top two records below 60\n4. for Display records of age between 13 and 16\n5. for Average Age\n6. for checking person present or not in list\n7 for Skip records below 60 age\n8. for Remove the record\n10. for Exit\n");
                Console.WriteLine("Enter Your choice");
                Choice = Convert.ToInt16(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        AddPersonData(list);
                        break;
                    case 2:
                        Display(list);
                        break;
                    case 3:
                        DisplayTopTwoBelow60(list);
                        break;
                    case 4:
                        DisplayAgeBetween13And18(list);
                        break;
                    case 5:
                        AverageAge(list);
                        break;
                    case 6:
                        Check(list);
                        break;
                    case 7:
                        SkipBelow60(list);
                        break;
                    case 8:
                        Remove(list);
                        break;
                    default:
                        Console.WriteLine("Oops you enter wrong input.. try again...");
                        break;

                }
            }
        }
    }
}
