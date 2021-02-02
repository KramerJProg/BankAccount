using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a single checking account
    /// </summary>
    public class Account
    {

        /// <summary>
        /// Deposits the amount in the bank account and 
        /// returns the new balance.
        /// </summary>
        /// <param name="amt">The amount to deposit.</param>
        public double Deposit(double amt)
        {
            if(amt <= 0)
            {
                throw new ArgumentException($"{nameof(amt)} must be a positive value");
            }

            Balance += amt;
            return Balance;
        }

        /// <summary>
        /// Gets the current balance.
        /// </summary>
        public double Balance { get; private set; }

        public void Withdraw(double amt)
        {

        }
    }
}
