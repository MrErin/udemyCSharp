using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Human
    {
        //member variable
        public string firstName;
        public string lastName;
        public string eyeColor;
        public int age;

        //constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }

    }
}
