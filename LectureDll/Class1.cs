using System;

namespace LectureDll
{
    public class Class1
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
}
