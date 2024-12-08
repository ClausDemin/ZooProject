using System.Drawing;

namespace ZooProject.View
{
    public class AviaryInfoWindow
    {
        private const int MarginRight = 5;

        private TextBox _aviaryInfo = new TextBox(new Point(0, 0), Console.BufferWidth - MarginRight);

        public void Show(string[] info) 
        { 
            Console.Clear();

            _aviaryInfo.UpdateText(info);
            _aviaryInfo.AppendText(" ");
            _aviaryInfo.AppendText("Для возврата в главное меню нажмите любую клавишу...", ConsoleColor.Yellow);

            Console.ReadKey(true);
            Closed.Invoke();
        }

        public event Action Closed = delegate { };
    }
}
