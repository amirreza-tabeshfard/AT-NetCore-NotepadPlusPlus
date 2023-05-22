using System;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UC.Second_Style;

public class MenuStripControls : MenuStrip
{
    #region Constructor
    
    public MenuStripControls()
    {
        this.Renderer = new MenuStripRenderer();
    } 

    #endregion
}