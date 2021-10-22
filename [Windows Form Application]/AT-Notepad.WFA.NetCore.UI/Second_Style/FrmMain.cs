using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI.Second_Style
{
    public partial class FrmMain : Form
    {
        #region Field(s)

        private readonly FrmAbout _frmAbout;

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

        #region Event(s) ==> Menu Help
        
        private void MenuHelp_About_Click(object sender, EventArgs e)
        {
            _frmAbout.ShowDialog();
        } 

        #endregion
    }
}