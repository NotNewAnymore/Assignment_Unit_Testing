using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Unit_Testing
{
    public class Savings : Account
    {
        double _interest;

        public Savings(double balance) : base(balance)
        {
            _interest = 5.00;
        }

        public override void Deposit(double amount)
        {
            if(amount >0)
            {
                _balance += amount + _interest; //Should we really be adding interest when deposits are made? My bank account adds interest regularly. Doing it this way lets people use a high transaction frequency to make as much money as they want.
            }
        }

        public override void Withdraw(double amount)
        {
            if(amount > 0)
            {
                _balance -= amount;
            }
        }
    }
}
