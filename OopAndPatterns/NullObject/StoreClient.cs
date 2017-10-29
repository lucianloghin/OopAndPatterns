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

        private void ClaimWaranty(SaleProduct product)
        {
            DateTime now = DateTime.Now;

            product.MoneyBackGuaranteeWarranty
                .Claim(now, () => Console.WriteLine("Can return money to customer"));
            
            product.NormalWaranty
                .Claim(now, () => Console.WriteLine("Can send product to service"));
        }
    }
}
