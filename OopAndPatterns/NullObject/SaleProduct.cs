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

        public SaleProduct(Warranty moneyBackGuarantee, Warranty express)
        {
            this.MoneyBackGuarantee = moneyBackGuarantee;
            this.ExpressWaranty = express;
        }
    }
}
