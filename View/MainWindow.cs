using System.Drawing;
using ZooProject.Presenter;
using ZooProject.View.ConsoleMenu;
using ZooProject.View.ConsoleMenu.Enums;
using ZooProject.View.Infrastructure;

namespace ZooProject.View
{
    public class MainWindow
    {
        private SwitchableMenu _mainMenu;

        private ZooPresenter _presenter;

        private bool _isExitRequested;

        public MainWindow(ZooPresenter presenter) 
        { 
            _presenter = presenter;

            var menuBuilder = new SwitchableMenuBuilder();

            foreach (var aviaryInfo in _presenter.AviariesInfo) 
            {
                menuBuilder.AddItem(aviaryInfo, () => ShowAviaryInfo(_mainMenu.GetCurrentItemIndex()));
            }

            menuBuilder.AddItem("Закрыть приложение", CloseApplication);

            _mainMenu = menuBuilder.Build(new Point(0, 0));
        }

        public void Run() 
        {
            _isExitRequested = false;

            Show();

            while (_isExitRequested == false)
            {
                var userInput = Console.ReadKey(true).Key;

                HandleUserInput(userInput);
            }
        }

        private void Show() 
        { 
            Console.Clear();

            _mainMenu.Show();

            Console.CursorVisible = false;
        }

        private void HandleUserInput(ConsoleKey userInput)
        {
            switch (userInput)
            {
                case ConsoleKey.UpArrow:
                    _mainMenu.MoveCursor(CursorMovement.Up);
                    break;

                case ConsoleKey.DownArrow:
                    _mainMenu.MoveCursor(CursorMovement.Down);
                    break;

                case ConsoleKey.Enter:
                    _mainMenu.Click();
                    break;
            }
        }

        private void CloseApplication() 
        { 
            _isExitRequested = true;
        }

        private void ShowAviaryInfo(int index) 
        {
            var aviaryInfo = _presenter.GetAviaryInfo(index);

            var aviaryInfoWindow = new AviaryInfoWindow();

            aviaryInfoWindow.Closed += Show;

            aviaryInfoWindow.Show(aviaryInfo);

            aviaryInfoWindow.Closed -= Show;
        }
    }
}
