using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObject_New
{
    public class ProductClass
    {
        #region NoValueObject
        //private string currency;
        //private string amount;

        //public string Currency { get; set; }
        //public string Amount { get; set; }
        #endregion

        private Price price;

        public Price Price { get; set; }
    }
}
