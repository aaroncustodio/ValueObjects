using System;
using ValueObject_New;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressDemo();
            SamplePrice();
            Console.ReadKey();
        }

        public static void SamplePrice()
        {
            ProductClass product = new ProductClass();

            //product.Amount = "10";
            //product.Currency = "PHP";

            //Console.WriteLine("Amount: {0}, Currency: {1}", product.Amount, product.Currency);

            Price price = new Price("100", "USD");

            product.Price = price;

            Console.WriteLine("Amount: {0}, Currency: {1}",
                product.Price.Amount, product.Price.Currency);
        }

        public static void AddressDemo()
        {
            #region ObjectInstantiation
            NormalObject_Address ads1 = new NormalObject_Address(
                "Mla-cav rd.", "cavite city", "4100");
            NormalObject_Address ads2 = new NormalObject_Address(
                "Mla-cav rd.", "cavite city", "4100");

            ValueObject_Address adrs1 = new ValueObject_Address(
                "Mla-cav rd.", "cavite city", "4100");
            ValueObject_Address adrs2 = new ValueObject_Address(
                "Mla-cav rd.", "cavite city", "4100");
            #endregion

            #region DisplayInfo
            Console.WriteLine("Normal Object Equality: {0}", ads1 == ads2);
            #region Hashcode1
            //Console.WriteLine("HashCodes:");
            //Console.WriteLine("Address 1: {0}\nAddress 2: {1}\n",
            //    ads1.GetHashCode(), ads2.GetHashCode());
            #endregion

            Console.WriteLine("Value Object Equality: {0}", adrs1 == adrs2);
            #region Hashcode2
            //Console.WriteLine("HashCodes:");
            //Console.WriteLine("Address 1: {0}\nAddress 2: {1}\n",
            //    adrs1.GetHashCode(), adrs2.GetHashCode());

            //PrintEqualityComponents(adrs1, adrs2);
            #endregion
            #endregion

            #region Hashcode3
            //ValueObject_Address a3 = new ValueObject_Address("a", "b", "c");
            //Console.WriteLine("HashCode:");
            //Console.WriteLine("Address 3: {0}", a3.GetHashCode()); 
            #endregion
        }

        public static void PrintEqualityComponents(
            ValueObject_Address a1, ValueObject_Address a2)
        {
            Console.WriteLine("Address 1:");
            foreach (string i in a1.GetEachPropertyValue())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Address 2:");
            foreach (string i in a2.GetEachPropertyValue())
            {
                Console.WriteLine(i);
            }
        }

    }
}
