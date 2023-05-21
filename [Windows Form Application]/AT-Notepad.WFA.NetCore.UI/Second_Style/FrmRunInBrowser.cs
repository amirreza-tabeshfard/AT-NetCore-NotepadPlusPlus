using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI.Second_Style
{
    public partial class FrmRunInBrowser : Form
    {
        #region Field(s)

        private String filename = default;

        #endregion

        #region Constructor

        public FrmRunInBrowser()
        {
            InitializeComponent();
        }

        #endregion

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txtBrowser.Text = openFileDialog.FileName;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBrowser.Text) && !string.IsNullOrEmpty(filename))
                if (File.Exists(txtBrowser.Text))
                {
                    Process.Start(txtBrowser.Text, filename);
                    this.Close();
                }
        }
    }
}