using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UC.Second_Style;

public class ToolStripControls : ToolStrip
{
    #region Constructor
    
    public ToolStripControls()
    {
        this.Renderer = new ToolStripRenderer();
    } 

    #endregion
}