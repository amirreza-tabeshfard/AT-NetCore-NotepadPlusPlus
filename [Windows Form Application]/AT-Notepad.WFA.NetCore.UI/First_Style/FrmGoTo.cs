using AT_Notepad.WFA.NetCore.Common.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI.First_Style
{
    public partial class FrmGoTo : Form
    {
        #region Field(s)

        private int _lineNumber;

        #endregion

        #region Constructor

        private FrmGoTo()
        {
            InitializeComponent();
        }

        public FrmGoTo(int lineNumber)
            : this()
        {
            LineNumber = lineNumber;
            txtLineNumber.Text = Convert.ToString(LineNumber);
        }

        #endregion

        #region Properties

        public int LineNumber
        {
            get
            {
                return _lineNumber;
            }
            set
            {
                _lineNumber = value;
            }
        }

        #endregion

        private void FrmGoTo_Load(object sender, EventArgs e)
        {
            txtLineNumber.SelectAll();
        }

        private void TxtLineNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                TextBox Sender = (TextBox)sender;
                toolTip.Show("Unacceptable Charater - You can only type a number here.", Sender);
                e.Handled = true;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGoTo_Click(object sender, EventArgs e)
        {
            if (txtLineNumber.Text.IsEmpty())
            {
                MessageBox.Show(this, "You must enter a value.", "Notepad Clone - Goto Line");
                return;
            }

            int PotentialLineNumber = Int32.Parse(txtLineNumber.Text);

            if (PotentialLineNumber == 0)
            {
                MessageBox.Show(this, "Zero (0) is not a valid line number, line numbers start at 1.", "Notepad Clone - Goto Line");
                return;
            }

            LineNumber = PotentialLineNumber;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}