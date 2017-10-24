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
        
        private IAccountState state;

        public Account(Action onUnfreeze)
        {
            this.state = new NotVerifiedState(onUnfreeze);
        }

        public void Deposit(decimal amount)
        {
            this.state = this.state.Deposit(() => this.Balance += amount);
        }

        public void Withdraw(decimal amount)
        {
            this.state = this.state.Withdraw(() => this.Balance -= amount);
        }

        public void HolderVerified()
        {
            this.state = this.state.HolderVerified();
        }

        public void Close()
        {
            this.state = this.state.Close();
        }

        public void Freeze()
        {
            this.state = this.state.Freeze();
        }
    }
}
