using ZooProject.Presenter;
using ZooProject.View;

namespace ZooProject
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var presenter = new ZooPresenter(2, 10);

            var mainWindow = new MainWindow(presenter);

            mainWindow.Run();
        }
    }
}
