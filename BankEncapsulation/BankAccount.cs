﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
    //In your BankAccount class, create the following:

    //    A private field of type double named balance with a value of 0
    //    Define a method named Deposit that will accept a double and store that value in the balance field
    //    Define a method named GetBalance that will return the amount stored in the balance field


}
