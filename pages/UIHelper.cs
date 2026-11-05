using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace E_9.pages
{
    public class UIHelper
    {
        public static void Redondear(Control control, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(control.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(control.Width - radio, control.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - radio, radio, radio), 90, 90);

            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}
