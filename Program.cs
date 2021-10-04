using System;
//Definition of Factory Design Pattern
/**
 * The Factory Design Pattern is one of the most frequently used design patterns in real-time applications.
 * The Factory Design Pattern in C# falls under the category of Creational Design Pattern
 */
namespace FactoryDesignPattern
{
  
    
    //According to Gang of Four
    //A factory is an object which is used for creating other objects
    /* In technical terms,
     * we can say that a factory is a class with a method.
     * That method will create and return different types of objects based on the input parameter,
     * it received. In simple words,
     * if we have a superclass and n number of subclasses,
     * and based on the data provided, if we have to create and return the object of one of the subclasses
     **/
    internal class Program
    {
        /*
         * In the Factory Design pattern,
         * we create an object without exposing the object creation logic to the client and the client will refer to the newly created object using a common interface.
         * The basic principle behind the factory design pattern is that, at run time,
         * we get an object of a similar type based on the parameter we pass
         * */
        static void Main(string[] args)
        {
            //Generally we will get the Card Type from UI.
            //Here we are hardcoded the card type
            string cardType = "Titanium";
            CreditCard cardDetails = null;
            //Based of the CreditCard Type we are creating the
            //appropriate type instance using if else condition
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
