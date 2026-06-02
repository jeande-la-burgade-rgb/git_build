using System.Collections.ObjectModel;
using System.Linq;
using git_build.Presentation.Models;
using git_build.Logic;

namespace git_build.Presentation.ViewModels
{
    public class LibViewMod
    {
        private readonly Elibrary_logic logic;

        public ObservableCollection<BookMod> Books { get; set; }

        public BookMod ? SelectedBook { get; set; }

        public LibViewMod(Elibrary_logic logic)
        {
            this.logic = logic;

            Books = new ObservableCollection<BookMod>(
                logic.GetBooks()
                     .Select(b => new BookMod
                    {
                        ISBN = b.ISBN,
                        Title = b.Title
                     })
            );
        }
    }
}