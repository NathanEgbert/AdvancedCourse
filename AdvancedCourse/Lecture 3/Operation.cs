using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace AdvancedCourse.Lecture_3
{
    class Operation
    {
        public delegate float myDelegate(decimal num1, decimal num2);

        private float GetTaxCalculation(decimal subtotal, decimal taxPercentage)
        {
            return (float)(subtotal * taxPercentage);
        }

        private float GetTotal(decimal subTotal, decimal tax)
        {
            return (float)(subTotal + tax);
        }

        private float CallMethods(myDelegate del, decimal d1, decimal d2)
        {
            return del(d1, d2);
        }

        [Test]
        public void DelegateTest()
        {
 
            Dictionary<decimal, decimal> values = new Dictionary<decimal, decimal>();
            values.Add(100, (decimal).15); //cast these
            values.Add(200, (decimal).17);
            values.Add(300, (decimal).19);
            values.Add(2500, (decimal).25);
            values.Add((decimal)2700.99, (decimal).27);

            foreach (var item in values)
            {

                var tax = CallMethods(this.GetTaxCalculation, item.Key, item.Value);
                var total = CallMethods(this.GetTotal, item.Key, (decimal)tax);

                Console.WriteLine("Tax Rate = " + tax);
                Console.WriteLine("Total = " + total);
            }
        }
    }
}
