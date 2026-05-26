using System.Collections.ObjectModel;
using git_build.Data;
using git_build.Logic;

namespace git_build.Presentation.ViewModels
{
    public class LibViewMod
    {
        private readonly Elibrary_logic logic;

        public ObservableCollection<Books_in_store> Books { get; set; }

        public Books_in_store SelectedBook { get; set; }

        public LibViewMod(Elibrary_logic logic)
        {
            this.logic = logic;

            Books = new ObservableCollection<Books_in_store>(
                logic.GetBooks()
            );
        }
    }
}