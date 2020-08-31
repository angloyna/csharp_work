using System;

namespace classes
{
    public class Person
    {
        public string Name;

        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age {
            get
            {
                DateTime today = DateTime.Now;
                var timeSpan = today - Birthdate;
                var years = timeSpan.Days/365;
                return years;
            }
        }
        public void Introduce(string friend)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", friend, Name);
        }

        public static Person Parse(DateTime birthday, string str)
        {
            var person = new Person(birthday);
            person.Name = str;
            return person;
        }
    }
}