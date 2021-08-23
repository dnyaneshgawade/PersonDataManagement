using System;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonData personData = new PersonData();
            PersonData.list.Add(new Person(){ SSN = 1, Name="Dnyanesh", Address="Kolhapur",Age=24});
            PersonData.list.Add(new Person(){ SSN = 2, Name = "Jay", Address = "Pune", Age = 15 });
            PersonData.list.Add(new Person(){ SSN = 3, Name = "Rahul", Address = "Goa", Age = 45 });
            PersonData.list.Add(new Person(){ SSN = 4, Name = "Mayuresh", Address = "Chennai", Age = 55});
            PersonData.list.Add(new Person(){ SSN = 5, Name = "Raj", Address = "Delhi", Age = 70 });
            personData.DataManagement();
        }
    }
}
