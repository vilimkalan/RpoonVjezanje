using Rpoon2Labos.Interfaces;
using Rpoon2Labos.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rpoon2Labos.DiceClasses
{
     class DiceRoller:ILogger
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        private Logger logger;
        private ILogger logger2;
        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            this.logger = new Logger("Console", null);

        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            //clear results of previous rolling
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        //View of the results
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
           this.resultForEachRoll
           );
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }
        public void LogRollingResults()
        {
            foreach (int result in this.resultForEachRoll)
            {
                logger.Log(result.ToString());
            }
        }
        public void SetLogger(ILogger logger)
        {
            logger2=logger;
        }
        void ILogger.Log(string message) 
        {
          logger2.Log(message);

        }

    }
}
