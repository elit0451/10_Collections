using System;

namespace _10_Collections
{
    internal class SavingsAccount : IAsset
    {
        public SavingsAccount(string account, double value, double interestRate)
        {
            Account = account;
            Value = value;
            InterestRate = interestRate;
        }

        public double InterestRate { get; internal set; }
        public string Account { get; set; }
        public double Value { get; set; }

        public override string ToString()
        {
            return "SavingsAccount[value=" + Value + ",interestRate=" + InterestRate + "]";
        }

        public double GetValue()
        {
            return Value;
        }

        internal void ApplyInterest()
        {
            Value = Value + (10 * InterestRate);
        }

        public string GetName()
        {
            return Account;
        }
    }
}