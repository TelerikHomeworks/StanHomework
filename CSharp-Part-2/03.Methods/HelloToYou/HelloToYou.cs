using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloToYou
{
    class HelloToYou
    {
        static void HelloTo(string name)
        {
            Console.WriteLine("Hello {0}",name);
        }

        static void Main(string[] args)
        {
            HelloTo("Iliyan");
        }
    }
}
