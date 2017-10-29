using System;

namespace OopAndPatterns.NullObject
{
    public interface IWarranty
    {
        void Claim(DateTime serviceDate, Action onClaimed);
    }
}