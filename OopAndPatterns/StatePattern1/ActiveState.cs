using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.StatePattern1
{
    class ActiveState : IAccountState
    {
        private Action OnUnfreeze { get; }

        public ActiveState(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;
        }

        public IAccountState Deposit(Action addToBalance)
        {
            addToBalance();
            return this;
        }

        public IAccountState Withdraw(Action substractFromBalance)
        {
            substractFromBalance();
            return this;
        }

        public IAccountState Freeze() => new FrozenState(OnUnfreeze);

        public IAccountState Close() => new ClosedState();

        public IAccountState HolderVerified() => this;
    }
}
