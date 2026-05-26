using Microsoft.VisualStudio.TestTools.UnitTesting;
using git_build.Presentation.ViewModels;

namespace git_build.Tests
{
    [TestClass]
    public class ViewModelTests
    {
        [TestMethod]
        public void ViewModel_LoadsBooks()
        {
            // Arrange
            var logic = new FakeLogic();

            // Act
            var vm = new LibViewMod(logic);

            // Assert
            Assert.AreEqual(1, vm.Books.Count);
        }
    }
}