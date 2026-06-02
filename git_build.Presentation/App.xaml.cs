using git_build.Data;
using git_build.Data.Database;
using git_build.Logic;
using git_build.Presentation.ViewModels;
using System.Linq;
using System.Windows;

namespace git_build.Presentation
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            try
            {
                using (var db = new LibDbContext())
                {
                    if (!db.Books.Any())
                    {
                        db.Books.Add(new Books_in_store
                        {
                            ISBN = "9780441172719",
                            Title = "Dune"
                        });

                        db.Books.Add(new Books_in_store
                        {
                            ISBN = "9780553293357",
                            Title = "Foundation"
                        });

                        db.SaveChanges();
                    }
                    db.Database.EnsureCreated();

                    // DEBUG CHECK
                    var canConnect = db.Database.CanConnect();
                }

                Elibrary_data data = new Library_data();
                Elibrary_logic logic = new Library_logic(data);
                var vm = new LibViewMod(logic);

                var window = new Views.MainWindow(vm);
                window.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}