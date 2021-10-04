using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    /**Create the Product Interface
       * Here we need to create either an interface or an abstract class that will expose the operations a credit card should have.
       * So, create a class file with the name CreditCard.cs and then copy and paste the following code in it.
       * As you can see, we created the interface with three methods
     * */
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
