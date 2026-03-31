namespace RppoonLv_1.Classes
{
    public class Quote
    {
        public string AuthorName { get; private set; }
        public string AuthorSurname { get; private set; }
        public DateOnly AuthorBirthDate { get; private set; }
        public string Text { get; private set; }
        public int Votes { get; set; }

        private IList<string> tags;
        public Author Author { get; private set; }
        public Quote(string authorName, string authorLastName, DateOnly authorDateOfBirth, string text)

        {
            if (text == null) throw new NotImplementedException();
            Text = text;
            Author = new Author(authorName, authorLastName, authorDateOfBirth);
            tags = new List<string>();
        }
        public Quote(Author author, string text)
        {

            if (text == null) throw new NotImplementedException();
            Author = author;
            Text = text;
            tags = new List<string>();
        }

        public void Upvote()
        {
            Votes++;


        }
        public void Downvote()
        {

            if (Votes - 1 < 0) throw new NotImplementedException();
            Votes--;
        }
        public void AddTag(string newTag)
        {
            if (newTag == null) throw new NotImplementedException();
            newTag.ToLower();
            tags.Add(newTag);
        }
        public IList<string> GetAllTags()
        {
            return tags.AsReadOnly();
        }
        public override string ToString()
        {
            return $"{Author.AuthorName},{Author.AuthorSurname},{Votes} ";
        }
    }
}
