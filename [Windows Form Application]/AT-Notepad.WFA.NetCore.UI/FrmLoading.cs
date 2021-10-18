using System;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI
{
    public partial class FrmLoading : Form
    {
        #region Field(s)

        private readonly FrmCase _frmCase;

        #endregion

        #region Constructor

        [Obsolete]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1041:Provide ObsoleteAttribute message", Justification = "<Pending>")]
        public FrmLoading()
        {
            InitializeComponent();
            _frmCase = new FrmCase();
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
                _frmCase.Show();
            }
        } 

        #endregion
    }
}