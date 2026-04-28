namespace git_build.Logic
{
    public interface Elibrary_logic
    {
        void BorrowBook(string userId, string isbn);
        void ReturnBook(string userId, string isbn);
    }
}
