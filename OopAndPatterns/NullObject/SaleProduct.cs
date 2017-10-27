using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.NullObject
{
    class SaleProduct
    {
        public Warranty MoneyBackGuarantee { get; }
        public Warranty ExpressWaranty { get; }
        public bool ProductInGoodCondition { get; }
        
        public SaleProduct(Warranty moneyBackGuarantee, Warranty express, bool productIsInGoodCondition)
        {
            this.MoneyBackGuarantee = moneyBackGuarantee ?? throw new ArgumentNullException("moneyBackGuarantee is null");
            this.ExpressWaranty = express ?? throw new ArgumentNullException("express warranty is null");
            this.ProductInGoodCondition = productIsInGoodCondition;
        }
    }
}
