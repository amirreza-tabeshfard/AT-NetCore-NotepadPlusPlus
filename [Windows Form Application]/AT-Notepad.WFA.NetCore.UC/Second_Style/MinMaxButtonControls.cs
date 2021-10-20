using System;
using System.Drawing;
using System.Windows.Forms;

using AT_Notepad.WFA.NetCore.Common.Enums;

namespace AT_Notepad.WFA.NetCore.UC.Second_Style
{
    public class MinMaxButtonControls : Button
    {
        #region Field(s)

        private Color clr1;
        private Color color = Color.White;
        private Color m_hovercolor = Color.FromArgb(180, 200, 240);
        private Color clickcolor = Color.FromArgb(160, 180, 200);
        private int textX = 6;
        private int textY = -20;
        private String text = "_";
        private CustomFormState _customFormState;

        #endregion

        #region Constructor

        public MinMaxButtonControls()
        {
            this.Size = new System.Drawing.Size(31, 24);
            this.ForeColor = Color.White;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Text = "_";
            text = this.Text;
        }

        #endregion

        #region Properties

        public CustomFormState CFormState
        {
            get
            {
                return _customFormState;
            }
            set
            {
                _customFormState = value;
                Invalidate();
            }
        }

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
                return clickcolor;
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
                return textX;
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
                return textY;
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

            switch (_customFormState)
            {
                case CustomFormState.Normal:
                    pe.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);

                    //draw and fill thw rectangles of maximized window     
                    for (int i = 0; i < 2; i++)
                    {
                        pe.Graphics.DrawRectangle(new Pen(this.ForeColor), textX + i + 1, textY, 10, 10);
                        pe.Graphics.FillRectangle(new SolidBrush(this.ForeColor), textX + 1, textY - 1, 12, 4);
                    }
                    break;

                case CustomFormState.Maximize:
                    pe.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);

                    //draw and fill thw rectangles of maximized window     
                    for (int i = 0; i < 2; i++)
                    {
                        pe.Graphics.DrawRectangle(new Pen(this.ForeColor), textX + 5, textY, 8, 8);
                        pe.Graphics.FillRectangle(new SolidBrush(this.ForeColor), textX + 5, textY - 1, 9, 4);

                        pe.Graphics.DrawRectangle(new Pen(this.ForeColor), textX + 2, textY + 5, 8, 8);
                        pe.Graphics.FillRectangle(new SolidBrush(this.ForeColor), textX + 2, textY + 4, 9, 4);

                    }
                    break;
            }

        }

        #endregion
    }
}