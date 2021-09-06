using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class BankFactory
    {
        public IBank GetBank(string type)
        {
            if (type=="SbiBank")
            {
                return new SbiBank();
            }
            else if(type == "HdfcBank")
            {
                return new HdfcBank();
            }
            return null;
        }
    }
}
