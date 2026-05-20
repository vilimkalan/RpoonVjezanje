using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Memento_ChainOfResponsibility.Classes3
{
    internal class CareTaker
    {
        private List<Memento> history = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            history.Add(memento);
        }

        public Memento GetLastMemento()
        {
            int lastIndex = this.history.Count - 1;
            Memento lastMemento = this.history[lastIndex];
            this.history.RemoveAt(lastIndex);
            return lastMemento;
        }

    }
}
