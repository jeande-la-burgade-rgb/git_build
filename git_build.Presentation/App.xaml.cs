using git_build.Logic;
using git_build.Presentation.ViewModels;
using System.Windows;

namespace git_build.Presentation
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var logic = new Library_logic();
            var vm = new LibViewMod(logic);

            var window = new Views.MainWindow(vm);
            window.Show();
        }
    }
}