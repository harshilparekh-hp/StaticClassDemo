using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    public class StaticConstructorDemo
    {
        public int i = 0;
        public static int j = 0;
        static StaticConstructorDemo()
        {
            Console.WriteLine("First, this will be executed (static)");
            j++;
            
        }

        public StaticConstructorDemo()
        {
            Console.WriteLine("Then, the normal execution starts");
            i++;
        }
    }
}
