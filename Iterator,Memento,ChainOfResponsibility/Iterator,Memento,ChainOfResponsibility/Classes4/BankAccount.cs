using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Memento_ChainOfResponsibility.Classes4
{
    class BankAccount
    {
        private string ownerName;
        private string ownerAddress;
        private decimal balance;

        public BankAccount(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }

        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }

        public void UpdateBalance(decimal amount)
        {
            this.balance += amount;
        }

        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }

       
        public override string ToString()
        {
            return $"Vlasnik: {this.ownerName}\nAdresa: {this.ownerAddress}\nStanje računa: {this.balance} EUR\n";
        }

       
        public BankAccountMemento StoreState()
        {
            return new BankAccountMemento(this.ownerName, this.ownerAddress, this.balance);
        }

        
        public void RestoreState(BankAccountMemento previous)
        {
            this.ownerName = previous.OwnerName;
            this.ownerAddress = previous.OwnerAddress;
            this.balance = previous.Balance;
        }

    }
}
