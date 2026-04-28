using Microsoft.VisualStudio.TestTools.UnitTesting;
using git_build.Logic;
using git_build.Data;

namespace git_build.Tests
{
    [TestClass]
    public class Lib_logic_test
    {
        [TestMethod]
        public void BorrowBook_AddsEvent()
        {
            var data = Test_data_fac.CreateWithOneBook();
            var logic = new Library_logic(data);

            logic.BorrowBook("user1", "123");

            Assert.AreEqual(1, data.Events.Count);
            Assert.AreEqual("Borrow", data.Events[0].Type);
        }

        [TestMethod]
        public void ReturnBook_RemovesBook()
        {
            var data = Test_data_fac.CreateWithOneBook();
            var logic = new Library_logic(data);

            logic.BorrowBook("user1", "123");
            logic.ReturnBook("user1", "123");

            Assert.AreEqual(0, data.State.BorrowedBooks.Count);
        }
    }
}
