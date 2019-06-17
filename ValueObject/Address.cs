using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace ValueObject
{
    public class Address : ValObject<Address>
    {
        public virtual string Street { get; protected set; }
        public virtual int ZipCode { get; protected set; }
        public virtual string Comment { get; protected set; }

        public Address(string street, int zipCode, string comment)
        {
            Street = street;
            ZipCode = zipCode;
            Comment = comment;
        }

        protected override bool EqualsCore(Address other)
        {
            return Street == other.Street && ZipCode == other.ZipCode;
        }

        protected override int GetHashCodeCore()
        {
            return (ZipCode.GetHashCode() * 397) ^ Street.GetHashCode();
        }
    }
}
