using git_build.Logic;
using git_build.Data;
using System.Collections.Generic;

namespace git_build.Tests
{
    public class FakeLogic : Elibrary_logic
    {
        public IEnumerable<BookIntel> GetBooks()
        {
            return new List<BookIntel>
            {
                new BookIntel
                {
                    ISBN = "123",
                    Title = "Test Book"
                }
            };
        }

        public void BorrowBook(string userId, string isbn)
        {
        }

        public void ReturnBook(string userId, string isbn)
        {
        }
    }
}