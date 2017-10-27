using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.NullObject
{
    class SaleProduct
    {
        // this acts as a return policy
        public IWarranty MoneyBackGuaranteeWarranty { get; private set; }
        public IWarranty NormalWaranty { get; private set; }
        private IWarranty NotOperationalWarranty { get; set; }

        public SaleProduct(IWarranty moneyBackGuaranteeWaranty, IWarranty normalWaranty)
        {
            if (moneyBackGuaranteeWaranty == null)
                throw new ArgumentNullException("moneyBackGuaranteeWaranty is null");
            if (normalWaranty == null)
                throw new ArgumentNullException("normalWaranty warranty is null");

            this.MoneyBackGuaranteeWarranty = moneyBackGuaranteeWaranty;
            this.NormalWaranty = new VoidWarranty();
            this.NotOperationalWarranty = normalWaranty;
        }

        public void NotOperational()
        {
            this.NormalWaranty = this.NotOperationalWarranty;
            this.MoneyBackGuaranteeWarranty = new VoidWarranty();
        }

        public void HasVisibleDamage()
        {
            this.MoneyBackGuaranteeWarranty = new VoidWarranty();
            this.NormalWaranty = new VoidWarranty();
        }
    }
}
