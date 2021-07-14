using System;

namespace PropChallenge
{
    class SavingsAcct : Account
    {
        private decimal _interest;
        private int withdrawcount = 0;
        public SavingsAcct(string firstName, string lastName, decimal interest, decimal balance) : base(firstName, lastName, balance) {
            _interest = interest;
        }

        public void ApplyInterest() {
            this.Balance = this.Balance + (this.Balance * _interest);
        }

        public override decimal Withdraw(decimal a)
        {
            try {
                if(this.Balance - a < 0) {
                    throw new ArgumentException("x", "Attempt to overdraw savings - denied");
                }
                withdrawcount++;
                if(withdrawcount > 3) {
                    Console.WriteLine("More than 3 withdrawals - extra charge");
                    this.Balance = this.Balance - 2 - a;
                    withdrawcount = 0;
                } else {
                    this.Balance = this.Balance - a;
                }
                // return this.Balance;
            }catch(ArgumentException e) {
                Console.WriteLine(e.Message);
            }
            return this.Balance;
        }
    }
}