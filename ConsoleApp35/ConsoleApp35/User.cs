using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp34
{
    public class User
    {
        internal static object user;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public User(string name, string surname, int age, string country)

        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;

        }
       

    }
}