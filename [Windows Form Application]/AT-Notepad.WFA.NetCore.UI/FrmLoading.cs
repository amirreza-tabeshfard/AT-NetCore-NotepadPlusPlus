using System;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI
{
    public partial class FrmLoading : Form
    {
        #region Field(s)

        private readonly FrmStyle _frmStyle;

        #endregion

        #region Constructor

        [Obsolete]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1041:Provide ObsoleteAttribute message", Justification = "<Pending>")]
        public FrmLoading()
        {
            InitializeComponent();
            _frmStyle = new FrmStyle();
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
                _frmStyle.Show();
            }
        } 

        #endregion
    }
}