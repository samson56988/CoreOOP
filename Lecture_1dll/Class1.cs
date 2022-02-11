using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1dll
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
