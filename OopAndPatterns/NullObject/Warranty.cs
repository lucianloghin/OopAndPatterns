﻿using System;

namespace OopAndPatterns.NullObject
{
    public class Warranty
    {
        private DateTime IssueDate { get; }

        public Warranty(DateTime issueDate)
        {
            this.IssueDate = issueDate;
        }

        public bool IsValidOn(DateTime serviceDate)
        {
            return this.IssueDate > serviceDate;
        }
    }
}