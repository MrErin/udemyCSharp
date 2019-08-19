//using System;

//namespace DecisionMaking
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("What's the temperature right now?");
//            string temperature = Console.ReadLine();
//            int numTemp;
//            int number;
//            bool userEnteredNumber = int.TryParse(temperature, out number);

//            if (userEnteredNumber)
//            {
//                numTemp = number;
//            } else
//            {
//                numTemp = 0;
//                Console.WriteLine("Value entered was not a number. Temperature is now 0.");
//            }

//            if(numTemp < 20)
//            {
//                Console.WriteLine("Put on coat");
//            }
//            else if (numTemp == 20)
//            {
//                Console.WriteLine("It's 10 degres C");
//            }

//            else
//            {
//                Console.WriteLine("Cozy & warm");
//            }

//            Console.ReadKey();
//        }
//    }
//}