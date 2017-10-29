using System;

namespace OopAndPatterns.NullObject
{
    public class Warranty : IWarranty
    {
        private DateTime IssueDate { get; }

        // todo : add singleton
        public Warranty(DateTime issueDate)
        {
            this.IssueDate = issueDate;
        }

        public void Claim(DateTime serviceDate, Action onClaimed)
        {
            if (!this.IsValidOn(serviceDate))
            {
                return;
            }

            onClaimed();
        }

        private bool IsValidOn(DateTime serviceDate)
        {
            return this.IssueDate >= serviceDate;
        }
    }
}