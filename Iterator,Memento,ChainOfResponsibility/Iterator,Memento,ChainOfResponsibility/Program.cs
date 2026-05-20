using Iterator_Memento_ChainOfResponsibility.Classes1;
using Iterator_Memento_ChainOfResponsibility.Classes2;
using Iterator_Memento_ChainOfResponsibility.Classes3;
using Iterator_Memento_ChainOfResponsibility.Classes4;
using Iterator_Memento_ChainOfResponsibility.Interfaces;
using Iterator_Memento_ChainOfResponsibility.Interfaces2;

namespace Iterator_Memento_ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook myNotebook = new Notebook();
            myNotebook.AddNote(new Note("Kupovina", "Mlijeko, kruh, kava, jaja."));
            myNotebook.AddNote(new Note("Faks", "Naučiti oblikovne obrasce za kolokvij!"));
            myNotebook.AddNote(new Note("Podsjetnik", "Platiti stanarinu do petka."));

            Console.WriteLine($"This many notes are in a notebook:{myNotebook.Count}\n");

            IAbstractIterator iterator = myNotebook.GetIterator();

            Console.WriteLine("Output by iterator___");

            while (!iterator.IsDone)
            {
                Note currentNote = iterator.Current;
                currentNote.Show();
                Console.WriteLine();

                iterator.Next();
            }
            Console.WriteLine("Test deleting first note");
            Note forDelete = myNotebook[0]; 
            myNotebook.RemoveNote(forDelete);
            Console.WriteLine($"After delete: {myNotebook.Count}\n");



            ///////////////////////////////////////////////////////////////////

            CareTaker careTaker = new CareTaker();

            ToDoItem task = new ToDoItem("Faks", "To study", DateTime.Now.AddDays(2));


            careTaker.AddMemento(task.StoreState());

            task.Rename("Faks-change");
            task.ChangeTask("write code for task3");

            careTaker.AddMemento(task.StoreState());

            task.Rename("Faks - over");
            task.ChangeTask("all solved");


            Console.WriteLine("Current state");
            Console.WriteLine(task);
            Console.WriteLine();

            Memento prethodno = careTaker.GetLastMemento();
            if (prethodno != null) task.RestoreState(prethodno);

            Console.WriteLine("after undo");
            Console.WriteLine(task);
            Console.WriteLine();

            prethodno = careTaker.GetLastMemento();
            if (prethodno != null) task.RestoreState(prethodno);
            Console.WriteLine("after 2. undo");
            Console.WriteLine(task);
            Console.WriteLine("\n\n");
            ////////////////////////////////////////////////////////
            ///

            BankAccountCareTaker BankCareTaker = new BankAccountCareTaker();

            BankAccount account = new BankAccount("Martin Bosancic", "Đuređakovica67", 500.00m);

            BankCareTaker.AddMemento(account.StoreState());

            account.ChangeOwnerAddress("bilice 29");
            account.UpdateBalance(250.50m);

            BankCareTaker.AddMemento(account.StoreState());

            account.UpdateBalance(-600.00m);

            Console.WriteLine("Current state of account");
            Console.WriteLine(account);

            BankAccountMemento prethodnoStanje = BankCareTaker.GetLastMemento();
            if (prethodnoStanje != null) account.RestoreState(prethodnoStanje);

            Console.WriteLine("after one undo");
            Console.WriteLine(account);



           prethodnoStanje=BankCareTaker.GetLastMemento();
            if (prethodnoStanje != null) account.RestoreState(prethodnoStanje);


            Console.WriteLine("after second undo");
            Console.WriteLine(account);







            Console.ReadLine();
        }


    }
}
