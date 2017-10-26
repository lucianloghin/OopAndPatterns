using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.NullObject
{
    class StoreClient
    {
        public void Test()
        {

        }

        private void ClaimWaranty(SaleProduct product, bool isInGoodCondition, bool isBroken)
        {
            DateTime now = DateTime.Now;

            if (!isInGoodCondition &&
                !isBroken &&
                product.MoneyBackGuarantee != null &&
                product.MoneyBackGuarantee.IsValidOn(now))
            {
                Console.WriteLine("Can return money to customer");
            }

            if (isBroken &&
                product.ExpressWaranty != null &&
                product.ExpressWaranty.IsValidOn(now))
            {
                Console.WriteLine("Can send product to service");
            }
        }
    }
}
