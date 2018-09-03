using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int Id { get; set; }

    public override string ToString()
    {
        return "ID: " + Id + ", Name: " + Name;
    }
}

public class Example
{
    public static void Main()
    {
        List <Person> people = new List<Person>();

        people.Add(new Person() { Id=1, Name = "John", Age = 24 });
        people.Add(new Person() { Id=2, Name = "Tom", Age = 27 });
        people.Add(new Person() { Id = 3, Name = "Simon", Age = 34 });

        foreach (Person element in people)
            Console.WriteLine(element);

        Console.ReadKey();
    }
}
