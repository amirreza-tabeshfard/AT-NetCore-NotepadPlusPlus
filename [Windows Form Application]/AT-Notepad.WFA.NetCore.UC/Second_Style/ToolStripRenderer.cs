using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UC.Second_Style
{
    internal class ToolStripRenderer : ToolStripProfessionalRenderer
    {
        #region Override
        
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderButtonBackground(e);
            var rectBorder = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
            var rect = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);
            Brush b2 = new System.Drawing.Drawing2D.LinearGradientBrush(e.Item.ContentRectangle, Color.FromArgb(30, 30, 30), Color.FromArgb(30, 30, 30), 90);
            Brush b4 = new System.Drawing.Drawing2D.LinearGradientBrush(e.Item.ContentRectangle, Color.FromArgb(30, 30, 30), Color.FromArgb(30, 30, 30), 90);

            if (e.Item.Selected == true || (e.Item as ToolStripButton).Checked)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, 80, 80)), rect);
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(50, 50, 50))), rectBorder);
                e.Item.ForeColor = Color.Black;
            }
            else
            {
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(50, 50, 50))), rectBorder);
                e.Graphics.FillRectangle(b4, rect);
            }

            if (e.Item.Pressed)
            {
                using (var b = new LinearGradientBrush(rect, Color.FromArgb(150, 150, 150), Color.FromArgb(150, 150, 150), 90))
                {
                    using (var b3 = new SolidBrush(Color.Black))
                    {
                        e.Graphics.FillRectangle(b3, rectBorder);
                        e.Graphics.FillRectangle(b, rect);
                    }
                }
            }
        } 

        #endregion
    }
}