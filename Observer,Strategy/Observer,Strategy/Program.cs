using Observer_Strategy.Classes;
using Observer_Strategy.classes2;

namespace Observer_Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double[] brojevi = { 5.5, 1.2, 9.8, 3.4, 0.7, 4.1 };
            Console.WriteLine("Originalni niz:");
            Console.WriteLine(string.Join(", ", brojevi));
            Console.WriteLine(new string('-', 30));

           
            NumberSequence sequence = new NumberSequence(brojevi);

            
            Console.WriteLine("Sortiranje pomoću BubbleSort-a:");
            sequence.SetSortStrategy(new BubbleSort());
            sequence.Sort();
            Console.WriteLine(sequence.ToString());

           
            double[] noviBrojevi = { 12.3, -2.5, 7.1, 0.0, 5.5 };
            NumberSequence sequence2 = new NumberSequence(noviBrojevi);

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Sortiranje pomoću CombSort-a:");
            sequence2.SetSortStrategy(new CombSort());
            sequence2.Sort();
            Console.WriteLine(sequence2.ToString());










            SystemDataProvider provider = new SystemDataProvider();

            
            ConsoleLogger consoleLog = new ConsoleLogger();
            FileLogger fileLog = new FileLogger("log_sustava.txt");

            provider.Attach(consoleLog);
            provider.Attach(fileLog);

            Console.WriteLine("Pokrenuto praćenje resursa. Pritisnite Ctrl+C za prekid...\n");

           
            while (true)
            {
               
                float cpu = provider.GetCPULoad();
                float ram = provider.GetAvailableRAM();

                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
