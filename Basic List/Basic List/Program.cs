using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int Id { get; set; }

    public override string ToString()
    {
        return "ID: " + Id + ", Name: " + Name + ", Age: " + Age;
    }
}

public class Example
{
    public static void Main()
    {
        List<Person> people = new List<Person>();

        people.Add(new Person() { Id=1, Name = "John", Age = 24, });
        people.Add(new Person() { Id=2, Name = "Tom", Age = 31 });
        people.Add(new Person() { Id = 3, Name = "Simon", Age = 34 });

        foreach (Person element in people)
        {
            Console.WriteLine("Id: " + element.Id);
            Console.WriteLine("Name: " + element.Name );
            Console.WriteLine("Age: " + element.Age);
            Console.WriteLine("---------------");
        }

        int maxAge = people.Max(s => s.Age);
        int minAge = people.Min(s => s.Age);

        Console.WriteLine("The oldest people is: {0}", maxAge);
        Console.WriteLine("The youngest people is: {0}", minAge);

        Console.ReadKey();
    }
}
