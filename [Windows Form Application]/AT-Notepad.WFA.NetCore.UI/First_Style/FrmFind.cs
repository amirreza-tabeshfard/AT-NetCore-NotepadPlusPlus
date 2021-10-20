using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AT_Notepad.WFA.NetCore.Common.Extensions;
using AT_Notepad.WFA.NetCore.Infrastructure.First_Style;

namespace AT_Notepad.WFA.NetCore.UI.First_Style
{
    public partial class FrmFind : Form
    {
        #region Field(s)

        private readonly FrmMain _frmMain;

        #endregion

        #region Constructor

        private FrmFind()
        {
            InitializeComponent();
        }

        public FrmFind(FrmMain frmMain)
            : this()
        {
            _frmMain = frmMain;
        }


        #endregion

        #region Private Method(s)

        private void UpdateFindNextButton()
        {
            btnFindNext.Enabled = (txtFindWhat.Text.Length > 0);
        }

        #endregion

        #region public Method(s)

        public void Triggered()
        {
            txtFindWhat.Focus();
        }

        public new void Show(IWin32Window window = null)
        {
            txtFindWhat.Focus();
            txtFindWhat.SelectAll();

            if (window == null)
                base.Show();
            else
                base.Show(window);
        }

        #endregion

        #region Event(s) ==> Form

        private void FrmFind_Load(object sender, EventArgs e)
        {
            UpdateFindNextButton();
        }

        private void FrmFind_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        #endregion

        #region Event(s) ==> btnFindNext

        private void BtnFindNext_Click(object sender, EventArgs e)
        {
            string SearchText = txtFindWhat.Text;
            bool isMatchCase = checkBoxMachCase.Checked;
            bool isRadioDown = radioDown.Checked;

            if (!_frmMain.FindAndSelect(SearchText, isMatchCase, isRadioDown))
            {
                MessageBox.Show(this, CONST.CannotFindMessage.FormatUsingObject(new
                {
                    SearchText
                }), "Notepad");
            }
        }

        #endregion

        #region Event(s) ==> btnCancel

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        #endregion

        #region Event(s) ==> txtFindWhat

        private void TxtFindWhat_TextChanged(object sender, EventArgs e)
        {
            UpdateFindNextButton();
        }

        private void TxtFindWhat_Enter(object sender, EventArgs e)
        {
            TextBox Sender = (TextBox)sender;
            Sender.SelectAll();
        }

        #endregion
    }
}