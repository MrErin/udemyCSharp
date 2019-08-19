using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human roxy = new Human("Roxy", "the Dog", "brown", 14);
            Human calliope = new Human("Calliope", "the Best Dog", "brown", 18);
            //roxy.IntroduceMyself();
            //calliope.IntroduceMyself();

            Box box = new Box();
            box.Length=5;
            box.Height = 3;
            box.Width = 4;

            box.displayInfo();
        }
    }
}
