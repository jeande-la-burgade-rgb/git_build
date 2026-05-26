using git_build.Logic;
using git_build.Data;
using System.Collections.Generic;

namespace git_build.Tests
{
    public class FakeLogic : Elibrary_logic
    {
        public IEnumerable<Books_in_store> GetBooks()
        {
            return new List<Books_in_store>
            {
                new Books_in_store
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