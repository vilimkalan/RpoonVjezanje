using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Memento_ChainOfResponsibility.Interfaces
{
     interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
