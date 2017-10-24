using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.StatePattern1
{
    class FrozenState : IAccountState
    {
        private Action OnUnfreeze { get; }

        public FrozenState(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;
        }

        public IAccountState Deposit(Action addToBalance)
        {
            this.OnUnfreeze();
            addToBalance();
            return new ActiveState(this.OnUnfreeze);
        }

        public IAccountState Withdraw(Action substractFromBalance)
        {
            this.OnUnfreeze();
            substractFromBalance();
            return new ActiveState(this.OnUnfreeze);
        }

        public IAccountState Freeze() => this;

        public IAccountState Close() => new ClosedState();

        public IAccountState HolderVerified() => this;
    }
}
