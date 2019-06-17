using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObject_New
{
    public class NormalObject_Address
    {
        public string Street { get; }
        public string City { get; }
        public string ZipCode { get; }

        public NormalObject_Address(string street, string city, string zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }
    }
}
