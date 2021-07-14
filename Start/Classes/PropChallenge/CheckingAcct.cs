using System;

namespace PropChallenge
{
    class CheckingAcct : Account
    {
        public CheckingAcct(string firstName, string lastName, decimal balance) : base(firstName, lastName, balance) {
            
        }

        public override decimal Withdraw(decimal a) {
            if(this.Balance - a < 0) {
                a = a + 35;
            }
            this.Balance = this.Balance - a;
            return this.Balance;
        }
    }
}