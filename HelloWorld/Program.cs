using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.BackgroundColor = ConsoleColor.DarkMagenta;
            //Console.Clear();
            //Console.WriteLine("Hello World!");
            //Console.Read();

            //int num1 = 13;
            //int num2 = 34;
            //int sum = num1 + num2;
            //double d1 = 3.5;
            //double d2 = 1.337;
            //double sumD = d1 + d2;
            //Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            //Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumD);

            //string myName = "Heloise";
            //string message = $"My name is {myName}.";
            //string capsMessage = message.ToUpper();
            //Console.WriteLine(capsMessage);
            //Console.Read();

            double myDouble = 13.37;
            int myInt;

            //explicit conversion
            myInt = (int)myDouble;

            //type conversion
            string myString = myDouble.ToString();

            bool sunIsShining = true;
            string myBoolString = sunIsShining.ToString();
            
            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}
