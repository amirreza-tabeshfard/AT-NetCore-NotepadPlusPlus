using System;
using System.Drawing;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UC.Second_Style
{
    public class CloseAndMinimumControls : Button
    {
        #region Field(s)

        private Color clr1;
        private Color color = Color.White;
        private Color m_hovercolor = Color.FromArgb(180, 200, 240);
        private Color clickcolor = Color.FromArgb(160, 180, 200);
        private int textX = 6;
        private int textY = -20;
        private String text = "_";

        #endregion

        #region Constructor

        public CloseAndMinimumControls()
        {
            this.Size = new Size(31, 24);
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Text = "_";
            text = this.Text;
        }

        #endregion

        #region Properties

        public String DisplayText
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                Invalidate();
            }
        }

        public Color BZBackColor
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                Invalidate();
            }
        }

        public Color MouseHoverColor
        {
            get
            {
                return m_hovercolor;
            }
            set
            {
                m_hovercolor = value;
                Invalidate();
            }
        }

        public Color MouseClickColor1
        {
            get
            {
                return
                  clickcolor;
            }
            set
            {
                clickcolor = value;
                Invalidate();
            }
        }

        public int TextLocation_X
        {
            get
            {
                return
                  textX;
            }
            set
            {
                textX = value;
                Invalidate();
            }
        }

        public int TextLocation_Y
        {
            get
            {
                return
                  textY;
            }
            set
            {
                textY = value;
                Invalidate();
            }
        }

        #endregion

        #region Override

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            clr1 = color;
            color = m_hovercolor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            color = clr1;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            color = clickcolor;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            color = clr1;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            text = this.Text;

            if (textX == 100 && textY == 25)
            {
                textX = ((this.Width) / 3) + 10;
                textY = (this.Height / 2) - 1;
            }

            Point p = new Point(textX, textY);
            pe.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);
            pe.Graphics.DrawString(text, this.Font, new SolidBrush(this.ForeColor), p);
        }

        #endregion
    }
}