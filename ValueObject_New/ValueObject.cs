using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueObject_New
{
    public abstract class ValueObject
    {
        //Used to return the individual property values of the object
        /*protected*/ public abstract IEnumerable<object> GetEachPropertyValue();

        public override bool Equals(object obj) //Overrides Equals fuction
        {
            if (obj == null) //if the object is false, return null
                return false;

            if (GetType() != obj.GetType()) //if the type of the current object is not
                return false;               //the same as the second object, return null


            var valueObject = (ValueObject)obj; //unboxing object into ValueObject type

            //Enumerable1.SequenceEqual(Enumerable2) Compares each property to check equality
            return GetEachPropertyValue().SequenceEqual(valueObject.GetEachPropertyValue());
        }

        public override int GetHashCode()
        {
            //Hashcode acts as an ID for the object, two value objects with the same property
            //should have the same hashcode
            return GetEachPropertyValue()
                .Aggregate(1, (current, obj) =>
                {
                    unchecked
                    {
                        return current * 23 + (obj?.GetHashCode() ?? 0);
                    }
                });
        }

        public static bool operator ==(ValueObject a, ValueObject b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject a, ValueObject b)
        {
            return !(a == b);
        }
    }
}
