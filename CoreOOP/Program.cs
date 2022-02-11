using System;
using LectureDll;

namespace CoreOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            printToScreenRandomNumber myRandomnumber = new printToScreenRandomNumber();
            myRandomnumber.printToScreen();

            printScreenV2 random_2 = new printScreenV2();
            random_2.printToScreen();


            Class1 dll = new Class1();
            dll.printToScreen();

        }

        class printToScreenRandomNumber
        {
            Random random = new Random();   
            public void printToScreen()
            {
                Console.WriteLine("PrintoScreen" + random.Next().ToString("N0"));
            }

            private void printToscreenPrivate()
            {
                Console.WriteLine(random.Next().ToString("N0"));
            }

            protected void printToScreenProtected()
            {
                Console.WriteLine(random.Next().ToString("N0"));
            }
        }

        class printScreenV2: printToScreenRandomNumber
        {
            public void printProtected()
            {
                printToScreenProtected();
            }
        }
    }
}
