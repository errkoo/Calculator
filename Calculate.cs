using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculate
    {
        int type; 
        double amount;

        public Calculate(double amount, int type) 
        {
            this.amount = amount;
            this.type = type;
        }

        public double returnAmount()
        {
            if(type == 1)
            {
                return ConvertToEuro();
            }
            else
            {
                return ConvertToBGN(); 
            }
        }

        public double ConvertToEuro() 
        {
            return amount * 0.51;
        }
        public double ConvertToBGN()
        {
            return amount * 1.96;
        }
    }
}
