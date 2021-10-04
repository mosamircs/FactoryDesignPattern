using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
   /** Creating Product Classes
     *  we have three Credit cards.
     *  So, we need to create three classes.
     *  First, create a class file with the name MoneyBack.cs
     *  and then copy and paste the following code into it.
     */
        class MoneyBack : CreditCard
        {
            public string GetCardType()
            {
                return "MoneyBack";
            }
            public int GetCreditLimit()
            {
                return 15000;
            }
            public int GetAnnualCharge()
            {
                return 500;
            }
        }
}
