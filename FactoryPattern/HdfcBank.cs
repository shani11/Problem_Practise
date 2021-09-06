using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class HdfcBank : IBank
    {
        public double calculateInterest()
        {
            return 7.4;
        }
    }
}
