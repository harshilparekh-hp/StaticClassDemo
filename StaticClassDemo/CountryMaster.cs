using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    public class CountryMaster
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        // derive your machine name.
        public string ComputerName
        {
            get
            {
                return CommonCountryCustomer.GetMachineName(); // "hparekh"
            }
        }

        public void Insert()
        {
            if(CommonCountryCustomer.IsNotEmpty(CountryCode) && CommonCountryCustomer.IsNotEmpty(CountryName))
            {
                // code to insert the data into Database using the above properties.
            }
        }
    }
}
