﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Basics.Bank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransactions)
                    balance += item.Amount;
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;
        private List<Transaction> _allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Number = accountNumberSeed++.ToString();
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive!");
            var deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive!");
            if (this.Balance - amount < 0)
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            var withdrawal = new Transaction(-amount, date, note);
            _allTransactions.Add(withdrawal);

        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tNote");
            foreach (var transaction in _allTransactions)
            {
                //Rows
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{transaction.Notes}");
            }
            return report.ToString();
        }
    }
}


