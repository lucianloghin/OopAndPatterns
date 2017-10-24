using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.StatePattern1
{
    interface IAccountState
    {
        IAccountState Deposit(Action addToBalance);

        IAccountState Withdraw(Action substractFromBalance);

        IAccountState Freeze();

        IAccountState Close();

        IAccountState HolderVerified();
    }
}
