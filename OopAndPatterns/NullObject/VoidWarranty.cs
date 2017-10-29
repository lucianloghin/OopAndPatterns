using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.NullObject
{
    class VoidWarranty : IWarranty
    {
        public void Claim(DateTime serviceDate, Action onClaimed)
        {
        }
    }
}
