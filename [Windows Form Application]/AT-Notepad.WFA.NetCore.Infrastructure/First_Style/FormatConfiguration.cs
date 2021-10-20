using System;
using System.Drawing;

namespace AT_Notepad.WFA.NetCore.Infrastructure.First_Style
{
    [Serializable]
    public class FormatConfiguration
    {
        #region Constructor

        public FormatConfiguration(Font currentFont)
        {
            CurrentFont = currentFont;
        }

        public FormatConfiguration(Color currentColor)
        {
            CurrentColor = currentColor;
        }

        public FormatConfiguration(Font currentFont, Color currentColor)
        {
            CurrentFont = currentFont;
            CurrentColor = currentColor;
        }

        #endregion

        #region Properties

        public Font CurrentFont { get; set; }

        public Color CurrentColor { get; set; }

        #endregion
    }
}