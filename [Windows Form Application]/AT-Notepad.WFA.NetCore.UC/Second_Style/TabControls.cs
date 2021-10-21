using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UC.Second_Style
{
    public class TabControls : TabControl
    {
        #region Field(s)

        private Color nonactive_color1 = Color.LightGreen;
        private Color nonactive_color2 = Color.DarkBlue;
        private Color active_color1 = Color.FromArgb(255, 210, 250, 220);
        private Color active_color2 = Color.FromArgb(255, 140, 160, 200);
        public Color forecolor = Color.Navy;
        private int color1Transparent = 150;
        private int color2Transparent = 150;
        private System.ComponentModel.IContainer components;
        private int angle = 90;

        #endregion

        #region Constructor

        public TabControls()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.Padding = new Point(30, 4);
        }

        #endregion

        #region Properties

        public Color ActiveTabStartColor
        {
            get
            {
                return
                  active_color1;
            }
            set
            {
                active_color1 = value;
                Invalidate();
            }
        }

        public Color ActiveTabEndColor
        {
            get
            {
                return
                  active_color2;
            }
            set
            {
                active_color2 = value;
                Invalidate();
            }
        }

        public Color NonActiveTabStartColor
        {
            get
            {
                return
                  nonactive_color1;
            }
            set
            {
                nonactive_color1 = value;
                Invalidate();
            }
        }

        public Color NonActiveTabEndColor
        {
            get
            {
                return
                  nonactive_color2;
            }
            set
            {
                nonactive_color2 = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get
            {
                return
                  forecolor;
            }
            set
            {
                forecolor = value;
                Invalidate();
            }
        }

        public int Transparent1
        {
            get
            {
                return color1Transparent;
            }
            set
            {
                color1Transparent = value;
                if (color1Transparent > 255)
                {
                    color1Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }

        public int Transparent2
        {
            get
            {
                return color2Transparent;
            }
            set
            {
                color2Transparent = value;
                if (color2Transparent > 255)
                {
                    color2Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }

        public int GradientAngle
        {
            get
            {
                return angle;
            }
            set
            {
                angle = value;
                Invalidate();
            }
        }

        #endregion

        #region Method(s)

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }

        #endregion

        #region Override

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            Rectangle rc = GetTabRect(e.Index);
            Rectangle rc2 = GetTabRect(e.Index);

            if (this.SelectedTab == this.TabPages[e.Index])
            {
                Color c1 = Color.FromArgb(color1Transparent, active_color1);
                Color c2 = Color.FromArgb(color2Transparent, active_color2);
                using (LinearGradientBrush br = new LinearGradientBrush(rc, c1, c2, angle))
                {
                    e.Graphics.FillRectangle(br, rc);
                }
            }
            else
            {
                Color c1 = Color.FromArgb(color1Transparent, nonactive_color1);
                Color c2 = Color.FromArgb(color2Transparent, nonactive_color2);
                using (LinearGradientBrush br = new LinearGradientBrush(rc, c1, c2, angle))
                {
                    e.Graphics.FillRectangle(br, rc);
                }
            }

            this.TabPages[e.Index].BorderStyle = BorderStyle.FixedSingle;
            this.TabPages[e.Index].ForeColor = SystemColors.ControlText;

            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-12, -4);

            e.Graphics.DrawString(this.TabPages[e.Index].Text, this.Font, new SolidBrush(forecolor), paddedBounds);
        }

        #endregion
    }
}