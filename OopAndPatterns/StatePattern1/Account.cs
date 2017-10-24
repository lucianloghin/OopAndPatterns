using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.StatePattern1
{
    public class Account
    {
        public decimal Balance { get; private set; }
        private Action OnUnfreeze { get; }

        private Action ManageUnfreezing;

        private bool isVerified;
        private bool isClosed;

        public Account(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;

            this.ManageUnfreezing = this.RemainUnfrozen;
        }

        public void Deposit(decimal amount)
        {
            if (!isClosed)
                return;

            this.ManageUnfreezing();

            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (!isVerified)
                return;
            if (!isClosed)
                return;

            this.ManageUnfreezing();

            this.Balance -= amount;
        }

        public void HolderVerified()
        {
            this.isVerified = true;
        }

        public void Close()
        {
            this.isClosed = true;
        }

        public void Freeze()
        {
            if (!isVerified)
                return;
            if (!isClosed)
                return;
            
            this.ManageUnfreezing = this.Unfreeze;
        }

        private void Unfreeze()
        {
            this.OnUnfreeze();

            this.ManageUnfreezing = this.RemainUnfrozen;
        }

        private void RemainUnfrozen()
        {
        }
    }
}
