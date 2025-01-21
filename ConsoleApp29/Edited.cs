using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Edited
    {
        public void Method()
        {
            Console.WriteLine("Hello World!");
        }

        public void Method2()
        {
            this.Method();
            this.Method();
            //test
        }

        public void Method3()
        {
            this.Method2();
            this.Method();
        }
    }
}
//This is a test file