using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Memento_ChainOfResponsibility.Classes4
{
    class BankAccountCareTaker
    {
        private List<BankAccountMemento> history = new List<BankAccountMemento>();

       
        public void AddMemento(BankAccountMemento memento)
        {
            this.history.Add(memento);
        }

      
        public BankAccountMemento GetLastMemento()
        {
            if (this.history.Count == 0)
            {
                return null;
            }

            int lastIndex = this.history.Count - 1;
            BankAccountMemento last = this.history[lastIndex];
            this.history.RemoveAt(lastIndex);
            return last;
        }
    }
}
