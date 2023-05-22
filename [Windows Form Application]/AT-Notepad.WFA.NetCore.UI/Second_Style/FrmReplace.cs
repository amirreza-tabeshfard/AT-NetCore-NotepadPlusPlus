using System;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI.Second_Style
{
    public partial class FrmReplace : Form
    {
        #region Field(s)

        private RichTextBox _richtext;

        #endregion

        #region Constructor

        public FrmReplace()
        {
            InitializeComponent();
        } 

        #endregion

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            _richtext.Text = _richtext.Text.Replace(txtFindWhat.Text, txtReplaceWith.Text);
        }
    }
}