using ZooProject.View.Intefaces;
using System.Drawing;

namespace ZooProject.View.Utils
{
    public static class UIUtils
    {
        public static Point GetPositionAfter(IUIElement element, int offset = 3) 
        { 
            var position = new Point(element.Position.X + element.Width + offset, element.Position.Y);

            return position;
        }
    }
}
