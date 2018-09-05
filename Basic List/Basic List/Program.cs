using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int Id { get; set; }

    public string Sex { get; set; }

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

        people.Add(new Person() { Id=1, Name="John", Age = 24, Sex="male" });
        people.Add(new Person() { Id=2, Name="Tom", Age = 31, Sex="male" });
        people.Add(new Person() { Id=3, Name="Simon", Age = 34, Sex="male" });
        people.Add(new Person() { Id=4, Name="Jennifer", Age = 22, Sex="female" });

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

        Console.WriteLine("----------------------");

        Console.WriteLine("Select only men or women (press 'm' of 'w')...");

        string clicked = Console.ReadLine();

        if ( clicked == "m" || clicked == "M" )
        {
            var menList = from person in people
                          where person.Sex == "male"
                          orderby person.Id
                          select person;

            Console.WriteLine("----------------");
            Console.WriteLine("Only men: ");

            foreach ( Person person in menList )
            {
                Console.WriteLine("*" + person.Name);
            }

        }
        else if ( clicked == "w" || clicked == "W" )
        {
            var womenList = from person in people
                            where person.Sex == "female"
                            orderby person.Id
                            select person;

            Console.WriteLine("----------------");
            Console.WriteLine("Only women: ");

            foreach ( Person person in womenList )
            {
                Console.WriteLine("*" + person.Name);
            }
        } 
        else if ( clicked == "" || clicked != "m" || clicked != "M" || clicked != "w" || clicked != "W")
        {
            Console.WriteLine("Try again! Select correct sex");
        }

        Console.ReadKey();
    }
}
