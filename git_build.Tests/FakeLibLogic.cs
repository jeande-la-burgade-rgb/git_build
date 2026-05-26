using Microsoft.VisualStudio.TestTools.UnitTesting;
using git_build.Logic;
using git_build.Data;

namespace git_build.Tests
{
    [TestClass]
    public class FakeLibLogic
    {
        [TestMethod]
        public void BorrowBook_AddsEvent()
        {
            var data = new FakeLibraryData();

            data.Users.Add(new Lib_user
            {
                Id = "user1",
                Name = "Test User"
            });

            data.Catalog.Add("123", new Books_in_store
            {
                ISBN = "123",
                Title = "Test Book"
            });

            var logic = new Library_logic(data);

            logic.BorrowBook("user1", "123");

            Assert.AreEqual(1, data.Events.Count);
            Assert.AreEqual("Borrow", data.Events[0].Type);
        }

        [TestMethod]
        public void ReturnBook_RemovesBook()
        {
            var data = new FakeLibraryData();

            data.Users.Add(new Lib_user
            {
                Id = "user1",
                Name = "Test User"
            });

            data.Catalog.Add("123", new Books_in_store
            {
                ISBN = "123",
                Title = "Test Book"
            });

            var logic = new Library_logic(data);

            logic.BorrowBook("user1", "123");
            logic.ReturnBook("user1", "123");

            Assert.AreEqual(0, data.State.BorrowedBooks.Count);
        }
    }
}
