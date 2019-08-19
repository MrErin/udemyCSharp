using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Box
    {
        private int length;
        private int height;
        private int width;
        private int volume;

        //public void SetLength(int length)
        //{
        //    this.length = length;
        //}
        //public int GetLength()
        //{
        //    return this.length;
        //}

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        
        public int Width { get; set; }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0) throw new Exception("Size should be positive");
                height = value;

            }
        }

        public void displayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, width is {2} and the volume is {3}", Length, Height, Width, volume = Width * Height * Length);
        }
    }
}
