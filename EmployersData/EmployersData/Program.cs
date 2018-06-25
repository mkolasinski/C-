using System;
using System.Collections.Generic;

namespace EmployersData
{
    public class Person
    { 
        public int IdPerson { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Person(int nPersonId, string sFirstName, string sLastName, int nAge, string sCity)
        {
            IdPerson = nPersonId;
            FirstName = sFirstName;
            LastName = sLastName;
            Age = nAge;
            City = sCity;

            List<Person> PersonObj = new List<Person>();
            PersonObj.Add(new Person(1, "Jan", "Kowalski", 28, "Gdańsk"));
            PersonObj.Add(new Person(2, "Robert", "Lewandowski", 31, "Warszawa"));
            PersonObj.Add(new Person(3, "Anna", "Kowacka", 29, "Rzeszów"));
            PersonObj.Add(new Person(4, "Paweł", "Nadolny", 30, "Łódź"));
            PersonObj.Add(new Person(5, "Danuta", "Rymanowska", 57, "Słupsk"));
            PersonObj.Add(new Person(6, "Mariusz", "Łukaszewski", 26, "Olsztyn"));
            
            foreach ( Person oPerson in PersonObj )
            {
                Console.WriteLine("Id: " + oPerson.IdPerson +
                    "Imię: " + oPerson.FirstName +
                    "Nazwisko: " + oPerson.LastName +
                    "Wiek: " + oPerson.Age +
                    "City: " + oPerson.City
                    );
            }
        }    
    }
}
