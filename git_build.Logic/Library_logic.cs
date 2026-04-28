using System;
using git_build.Data;

namespace git_build.Logic
{
    public class Library_logic : Elibrary_logic
    {
        private readonly Elibrary_data data;

        public Library_logic(Elibrary_data data)
        {
            this.data = data;
        }

        public void BorrowBook(string userId, string isbn)
        {
            if (!data.Catalog.ContainsKey(isbn))
                throw new Exception("Book not found");

            data.State.BorrowedBooks.Add(isbn);

            data.Events.Add(new Lib_event
            {
                Type = "Borrow",
                BookISBN = isbn,
                UserId = userId,
                Timestamp = DateTime.Now
            });
        }

        public void ReturnBook(string userId, string isbn)
        {
            if (!data.State.BorrowedBooks.Contains(isbn))
                throw new Exception("Book is not borrowed");

            data.State.BorrowedBooks.Remove(isbn);

            data.Events.Add(new Lib_event
            {
                Type = "Return",
                BookISBN = isbn,
                UserId = userId,
                Timestamp = DateTime.Now
            });
        }
    }
}
