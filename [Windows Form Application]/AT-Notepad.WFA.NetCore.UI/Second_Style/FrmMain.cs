using System;
using System.Drawing;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI.Second_Style;

public partial class FrmMain : Form
{
    #region Field(s)

    private readonly FrmAbout _frmAbout;

    private bool isTopPanelDragged = false;
    private bool isLeftPanelDragged = false;
    private bool isRightPanelDragged = false;
    private bool isBottomPanelDragged = false;
    private bool isTopBorderPanelDragged = false;
    private bool isWindowMaximized = false;
    private Point offset;
    private Size _normalWindowSize = new Size(new Point(0, 0));
    private Point _normalWindowLocation = Point.Empty;

    #endregion

    #region Constructor

    [Obsolete]
    public FrmMain()
    {
        InitializeComponent();
        _frmAbout = new FrmAbout();
    }

    #endregion

    #region Event(s) ==> Form

    private void FrmMain_Load(object sender, EventArgs e)
    {

    }

    #endregion

    #region Event(s) == > TopPanel

    private void TopPanel_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isTopPanelDragged = true;
            Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
            offset = new Point();
            offset.X = this.Location.X - pointStartPosition.X;
            offset.Y = this.Location.Y - pointStartPosition.Y;
        }
        else
        {
            isTopPanelDragged = false;
        }
        if (e.Clicks == 2)
        {
            isTopPanelDragged = false;
            BtnMaximum_Click(sender, e);
        }
    }

    private void TopPanel_MouseMove(object sender, MouseEventArgs e)
    {
        if (isTopPanelDragged)
        {
            Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
            newPoint.Offset(offset);
            this.Location = newPoint;

            if (this.Location.X > 2 || this.Location.Y > 2)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.Location = _normalWindowLocation;
                    this.Size = _normalWindowSize;
                    toolTip.SetToolTip(BtnMaximum, "Maximize");
                    BtnMaximum.CFormState = Common.Enums.CustomFormState.Normal;
                    isWindowMaximized = false;
                }
            }
        }
    }

    private void TopPanel_MouseUp(object sender, MouseEventArgs e)
    {
        isTopPanelDragged = false;
        if (this.Location.Y <= 5)
        {
            if (!isWindowMaximized)
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                toolTip.SetToolTip(BtnMaximum, "Restore Down");
                BtnMaximum.CFormState = Common.Enums.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        this.Close();
        Application.Exit();
    }

    private void BtnMaximum_Click(object sender, EventArgs e)
    {
        if (isWindowMaximized)
        {
            this.Location = _normalWindowLocation;
            this.Size = _normalWindowSize;
            toolTip.SetToolTip(BtnMaximum, "Maximize");
            BtnMaximum.CFormState = Common.Enums.CustomFormState.Normal;
            isWindowMaximized = false;
        }
        else
        {
            _normalWindowSize = this.Size;
            _normalWindowLocation = this.Location;

            Rectangle rect = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(0, 0);
            this.Size = new System.Drawing.Size(rect.Width, rect.Height);
            toolTip.SetToolTip(BtnMaximum, "Restore Down");
            BtnMaximum.CFormState = Common.Enums.CustomFormState.Maximize;
            isWindowMaximized = true;
        }
    }

    private void BtnMinimum_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    #endregion

    #region MenuStrip(s)

    #region Event(s) ==> Menu File

    private void MenuFile_New_Click(object sender, EventArgs e)
    {

    }

    #endregion

    #region Event(s) ==> Menu Help

    private void MenuHelp_About_Click(object sender, EventArgs e)
    {
        _frmAbout.ShowDialog();
    }

    #endregion

    #endregion
}