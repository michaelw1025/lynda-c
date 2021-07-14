using System;

namespace PropChallenge
{
    class Account
    {
        private string _firstname;
        private string _lastname;
        private decimal _balance;

        public Account(string firstName, string lastName, decimal balance) {
            _firstname = firstName;
            _lastname = lastName;
            _balance = balance;
        }

        public string FirstName {
            // return the name
            get { return _firstname; }
            // use setter to validate the new property value
            set {
                if (value == "") {
                    throw new ArgumentException("First name cannot be blank");
                }
                _firstname = value;
            }
        }
        public string LastName {
            // return the name
            get { return _lastname; }
            // use setter to validate the new property value
            set {
                if (value == "") {
                    throw new ArgumentException("Last name cannot be blank");
                }
                _lastname = value;
            }
        }
        public decimal Balance {
            get => _balance;
            set => _balance = value;
        }

        public string AccountOwner {
            get => $"{FirstName} {LastName}";
        }

        public decimal Deposit(decimal a) {
            _balance = _balance + a;
            return _balance;
        }
        public virtual decimal Withdraw(decimal a) {
            _balance = _balance - a;
            return _balance;
        }
    }
}