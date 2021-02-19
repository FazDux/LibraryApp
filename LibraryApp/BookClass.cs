namespace LibraryApp
{
    public class BookClass
    {
        private string _title;
        private string _author;
        private bool _isborrowed;

        public string Title => _title;
        public string Author => _author;
        public bool IsBorrowed
        {
            get => _isborrowed;
            set => _isborrowed = value;
        }

        public BookClass(string title, string author, bool isborrowed)
        {
            _title = title;
            _author = author;
            _isborrowed = isborrowed;
        }
        
    }
}