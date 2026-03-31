namespace RppoonLv_1.Classes
{
    public class QuotesDatabase
    {
        private IDictionary<string, Author> authors;
        private IList<Quote> quotes;
        public QuotesDatabase()
        {
            authors = LoadAuthors();
            quotes = LoadQuotes();
        }
        private IDictionary<string, Author> LoadAuthors()
        {
            return new Dictionary<string, Author>()
 {
 {"RM", new Author("Robert", "Martin", new DateOnly(1952, 12, 5)) },
 {"MF", new Author("Martin", "Fowler", new DateOnly(1963, 12, 18)) },
 {"KB", new Author("Kent", "Beck", new DateOnly(1961, 3, 31)) },
 };
        }
        private IList<Quote> LoadQuotes()
        {
            return new List<Quote>()
            {
                new Quote(authors["RM"], "Truth can only be found in one place: the code."),

                new Quote(authors["RM"], "Indeed, the ratio of time spent reading versus writing is well over 10 to 1. We are constantly reading old code as part of the effort to write new code. Making it easy to read makes it easier to write."),

                new Quote(authors["RM"], "It is not enough for code to work."),

                new Quote(authors["RM"], "A long descriptive name is better than a short enigmatic name. A long descriptive name is better than a long descriptive comment."),

                new Quote(authors["RM"], "You should name a variable using the same care with which you name a first-born child."),

                new Quote(authors["MF"], "A heuristic we follow is that whenever we feel the need to comment something, we write a method instead."),

                new Quote(authors["MF"], "I've learned to always avoid saying \"always\"."),

                new Quote(authors["MF"], "Now I'm a pretty lazy person and am prepared to work quite hard in order to avoid work."),

                new Quote(authors["MF"], "Most programmers, even experienced ones, are poor judges of how code actually performs."),

                new Quote(authors["MF"], "Code that communicates its purpose is very important."),

                new Quote(authors["KB"], "Do the simplest thing that could possibly work"),

                new Quote(authors["KB"], "I'm not a great programmer; I'm just a good programmer with great habits."),

                new Quote(authors["KB"], "You can always start improving today."),

                new Quote(authors["KB"], "Flexibility can come at the cost of increased complexity."),

                new Quote(authors["KB"], "First you learn the value of abstraction, then you learn the cost of abstraction, then you're ready to engineer.") };
        }

        public IList<Author> GetAuthors()
        {
            return authors.Values.ToList().AsReadOnly();
        }
        public IList<Quote> GetQuotes()
        {
            return quotes.AsReadOnly();
        }

        public IList<Quote> GetAuthorsQuotes(string authorName, string authorSurname)
        {
            IList<Quote> listOfAuthorQuotes = new List<Quote>();
            

            string initials = CreateInitials(authorName, authorSurname);

            foreach (var quote in quotes)
            {
                if (quote.Author == authors[initials])
                {
                    listOfAuthorQuotes.Add(quote);
                }
            }
            return listOfAuthorQuotes;
        }

        public string CreateInitials(string authorName, string authorSurname)
        {
            string initials = "";
            return initials += authorName.Substring(0,1).ToUpper() + authorSurname.Substring(0,1).ToUpper();

        }
    }
}
/*U klasu koja predstavlja bazu citata dodajte metodu koja omogućuje dohvaćanje svih citata nekog autora.
 * 
Metodi se predaju ime i prezime autora. Metoda mora raditi neovisno o velikim i malim slovima. U slučaju da
autor ne postoji u bazi ili nema njegovih citata, vraća se prazna lista citata. Testirajte napisanu metodu s
jednim autorom koji postoji i jednim koji ne postoji.*/