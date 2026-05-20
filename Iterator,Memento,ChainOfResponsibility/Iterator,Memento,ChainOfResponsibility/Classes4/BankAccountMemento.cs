using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Memento_ChainOfResponsibility.Classes4
{
    class BankAccountMemento
    {
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccountMemento(string name, string address, decimal balance)
        {
            this.OwnerName = name;
            this.OwnerAddress = address;
            this.Balance = balance;
        }
    }
}
