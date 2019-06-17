using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObject_New
{
    public class ValueObject_Address : ValueObject
    {
        //no setters, value objects must be immutable
        public string Street { get; }
        public string City { get; }
        public string ZipCode { get; }


        public ValueObject_Address(string street, string city, string zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }

        //used for comparison between two value objects
        /*protected*/ public override IEnumerable<object> GetEachPropertyValue()
        {
            yield return Street;
            yield return City;
            yield return ZipCode;
        }
    }
}
