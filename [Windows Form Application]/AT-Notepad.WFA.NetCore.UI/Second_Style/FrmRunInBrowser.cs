using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI.Second_Style
{
    public partial class FrmRunInBrowser : Form
    {
        #region Field(s)

        private String _filename = default;

        #endregion

        #region Constructor

        public FrmRunInBrowser(string filename)
        {
            InitializeComponent();
            _filename = filename;
        }

        #endregion

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txtBrowser.Text = openFileDialog.FileName;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBrowser.Text) && !string.IsNullOrEmpty(_filename))
                if (File.Exists(txtBrowser.Text))
                {
                    Process.Start(txtBrowser.Text, _filename);
                    this.Close();
                }
        }
    }
}