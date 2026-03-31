using RppoonLv_1.Classes;

namespace RppoonLv_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quote kvot = new Quote("vilim", "Kalan", new DateOnly(2006, 1, 11), "bilo jednom davno");
            kvot.AddTag("prvi");
            kvot.AddTag("prvi");
            kvot.AddTag("prvi");
            kvot.AddTag("prvi");
            kvot.Upvote();
            kvot.Upvote();
            kvot.Upvote();
            kvot.Upvote();

            foreach (var tag in kvot.GetAllTags())
            {
                Console.WriteLine(tag.ToString());
            }
            Console.WriteLine(kvot.ToString());



            QuotesDatabase quotesDatabase = new QuotesDatabase();

            IList<Quote> listOfAuthorsQuotes = quotesDatabase.GetAuthorsQuotes("robert", "martin");

            foreach (Quote quote in listOfAuthorsQuotes) { 
                Console.WriteLine(quote.Text);
            }
        }


    }

   








}
