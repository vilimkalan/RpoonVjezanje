namespace RppoonLv_1.Classes
{
    public class Author
    {
        public string AuthorName { get; private set; }
        public string AuthorSurname { get; private set; }
        public DateOnly AuthorBirthDate { get; private set; }

        public Author(string authorName, string authorSurname, DateOnly authorBirthDate)
        {
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            AuthorBirthDate = authorBirthDate;
        }
    }
}
