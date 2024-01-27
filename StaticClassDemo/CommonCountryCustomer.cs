using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    /// <summary>
    // we cannot create the object of static class as it does not implement the OOP principles.
    // static classes/methods are created when the behavior is fixed across the application.
    // and the class does not represent any real world objects and the methods in the static
    // class are unrelated.
    // you can not inherit static class.

    // we can not even create/define non-static members inside static class.
    // but, in concrete class, we can create static members.

    /// </summary>

    public static class CommonCountryCustomer
    {
        public static bool IsNotEmpty(string value)
        {
            if (value.Length > 0)
                return true;
            else
                return false;
        }

        public static string GetMachineName()
        {
            return System.Environment.MachineName;
        }
    }
}
