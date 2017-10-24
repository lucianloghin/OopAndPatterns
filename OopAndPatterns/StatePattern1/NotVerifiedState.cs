using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.StatePattern1
{
    class NotVerifiedState : IAccountState
    {
        public Action OnUnfreeze { get; }

        public NotVerifiedState(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;
        }

        public IAccountState Close() => new ClosedState();

        public IAccountState Deposit(Action addToBalance) => this;

        public IAccountState Freeze() => this;

        public IAccountState HolderVerified() => new ActiveState(this.OnUnfreeze);

        public IAccountState Withdraw(Action substractFromBalance) => this;
    }
}
