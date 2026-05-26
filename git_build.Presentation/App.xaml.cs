using git_build.Data;
using git_build.Data.Database;
using System.Windows;
using System.Linq;

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
                    MessageBox.Show($"DB created / connection: {canConnect}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}