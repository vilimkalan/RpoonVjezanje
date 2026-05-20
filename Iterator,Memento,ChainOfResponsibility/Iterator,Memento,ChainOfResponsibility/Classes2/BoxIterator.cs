using Iterator_Memento_ChainOfResponsibility.Interfaces2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Memento_ChainOfResponsibility.Classes2
{
    class BoxIterator : IAbstractBoxIterator
    {
        private Box box;
        private int currentPosition;

        public BoxIterator(Box box)
        {
            this.box = box;
            this.currentPosition = 0;
        }

        public bool IsDone { get { return this.currentPosition >= this.box.Count; } }
        public Product Current { get { return this.box[this.currentPosition]; } }

        public Product First()
        {
            this.currentPosition = 0;
            return this.box[0];
        }

        public Product Next()
        {
            this.currentPosition++;
            if (this.IsDone)
            {
                return null;
            }
            else
            {
                return this.box[this.currentPosition];
            }
        }
    }
}
