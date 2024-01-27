using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    public class CustomerMaster
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }

        private string ComputerName = "";

        public CustomerMaster()
        {
            ComputerName = CommonCountryCustomer.GetMachineName();
        }
       

        public void Insert()
        {

            // validation to check if CustomerCode and CustomerName is not empty,
            if (CommonCountryCustomer.IsNotEmpty(CustomerCode) && CommonCountryCustomer.IsNotEmpty(CustomerName))
            {
                // then only insert the data into database for both of the above properties
            }
        }

    }
}
