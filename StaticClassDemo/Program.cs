using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    //read-only
    internal class Program
    {
        static void Main(string[] args)
        {
           
            StaticConstructorDemo sc = new StaticConstructorDemo();
            
            Console.WriteLine("value of static member {0}", StaticConstructorDemo.j.ToString());

            Console.ReadKey();

        }
    }
}
