using Iterator_Memento_ChainOfResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Memento_ChainOfResponsibility.Interfaces2
{
    interface IAbstractBoxCollection
    {
        IAbstractBoxIterator GetIterator();
    }
}
