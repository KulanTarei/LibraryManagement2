namespace LibraryManagement2
{
    public static class DataStore
    {
        public static List<Book> Books { get; set; } = new List<Book>();
        public static List<Member> Members { get; set; } = new List<Member>();
        public static List<Borrowing> Borrowings { get; set; } = new List<Borrowing>();
    }

}
