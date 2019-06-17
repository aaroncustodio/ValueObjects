using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObject_New
{
    public class Price : ValueObject
    {
        //no setters, value objects must be immutable
        public string Amount { get; }
        public string Currency { get; }

        public Price(string amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override IEnumerable<object> GetEachPropertyValue()
        {
            yield return Amount;
            yield return Currency;
        }
    }
}
