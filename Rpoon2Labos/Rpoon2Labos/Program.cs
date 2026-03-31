using Rpoon2Labos.DiceClasses;

namespace Rpoon2Labos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DiceRoller diceRoller= new DiceRoller();
            Random randomGenerator = new Random();
            for(int i=0; i<20; i++)
            {
                Die die = new Die(6,randomGenerator);
                diceRoller.InsertDie(die);

            }
            diceRoller.RollAllDice(); 
            IList<int> DieList = diceRoller.GetRollingResults();
            foreach (var dice in DieList)
            {
                Console.WriteLine(dice);
            }


        }
    }
}
