using CSharpCourseExceptionExercise.Entities.Exceptions;

namespace CSharpCourseExceptionExercise.Entities {
    public class Account {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit) {

            if (balance < 0 || withdrawLimit < 0) {
                throw new DomainException("Value cannot be negative!");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void deposit(double amount) {
            Balance += amount;
        }

        public void withdraw(double amount) {
            if (amount > Balance) {
                throw new DomainException("Not enough balance!");
            }
            if (amount > WithdrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit!");
            }
            Balance -= amount;
        }

    }
}
