using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.StatePattern1
{
    class AccountInitialForm
    {
        public decimal Balance { get; private set; }

        private Action OnUnfreeze { get; }
        private bool IsVerified { get; set; }
        private bool IsClosed { get; set; }
        private bool IsFrozen { get; set; }

        public AccountInitialForm(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;
        }

        public void Deposit(decimal amount)
        {
            if (!this.IsVerified)
                return;
            if (!this.IsClosed)
                return;
            if (this.IsFrozen)
            {
                this.IsFrozen = false;
                this.OnUnfreeze();
            }

            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (!this.IsVerified)
                return;
            if (!this.IsClosed)
                return;

            this.Balance -= amount;
        }

        public void Close()
        {
            this.IsClosed = true;
        }

        public void HolderVerified()
        {
            IsVerified = true;
        }

        public void Freeze()
        {
            if (!this.IsVerified)
                return;
            if (!this.IsClosed)
                return;

            this.IsFrozen = true;
        }
    }
}
