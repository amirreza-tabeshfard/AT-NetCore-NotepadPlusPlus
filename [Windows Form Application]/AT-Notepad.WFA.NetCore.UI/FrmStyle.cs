using System;
using System.Windows.Forms;

using FirstStyle = AT_Notepad.WFA.NetCore.UI.First_Style;
using SecondStyle = AT_Notepad.WFA.NetCore.UI.Second_Style;

namespace AT_Notepad.WFA.NetCore.UI
{
    public partial class FrmStyle : Form
    {
        #region Field(s)

        private readonly FirstStyle.FrmMain _firstStyleFrmMain;
        private readonly Second_Style.FrmMain _secondStyleFrmMain;

        #endregion

        [Obsolete]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1041:Provide ObsoleteAttribute message", Justification = "<Pending>")]
        public FrmStyle()
        {
            InitializeComponent();
            _firstStyleFrmMain = new FirstStyle.FrmMain();
            _secondStyleFrmMain = new SecondStyle.FrmMain();
        }

        private void Buttons_Click(object sender, EventArgs e)
        { 
            if (sender is Button)
                switch ((sender as Button).Name)
                {
                    case "BtnOne":
                        {
                            this.Hide();
                            _firstStyleFrmMain.Show();
                        }
                        break;

                    case "BtnTwo":
                        {
                            this.Hide();
                            _secondStyleFrmMain.Show();
                        }
                        break;
                }
        }
    }
}