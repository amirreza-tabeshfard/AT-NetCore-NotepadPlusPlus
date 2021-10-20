using System;
using System.Windows.Forms;

using AT_Notepad.WFA.NetCore.UI.First_Style;

namespace AT_Notepad.WFA.NetCore.UI
{
    public partial class FrmStyle : Form
    {
        #region Field(s)

        private readonly FrmMain _frmMain;

        #endregion

        [Obsolete]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1041:Provide ObsoleteAttribute message", Justification = "<Pending>")]
        public FrmStyle()
        {
            InitializeComponent();
            _frmMain = new FrmMain();
        }

        private void Buttons_Click(object sender, EventArgs e)
        { 
            if (sender is Button)
                switch ((sender as Button).Name)
                {
                    case "BtnOne":
                        {
                            this.Hide();
                            _frmMain.Show();
                        }
                        break;

                    case "BtnTwo":
                        {
                            MessageBox.Show("Is being implemented.", "Pending", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                        }
                        break;
                }
        }
    }
}