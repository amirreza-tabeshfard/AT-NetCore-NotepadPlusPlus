using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI
{
    public partial class FrmLoading : Form
    {
        #region Field(s)

        private readonly First_Case.FrmMain frmMainFist;

        #endregion

        #region Constructor

        [Obsolete]
        public FrmLoading()
        {
            InitializeComponent();
            frmMainFist = new First_Case.FrmMain();
        }

        #endregion

        #region Events Components
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Text = $"Loadinng: {progressBar.Value++}%";

            if (progressBar.Value == progressBar.Maximum)
            {
                timer.Enabled = false;
                this.Hide();
                frmMainFist.Show();
            }
        } 

        #endregion
    }
}