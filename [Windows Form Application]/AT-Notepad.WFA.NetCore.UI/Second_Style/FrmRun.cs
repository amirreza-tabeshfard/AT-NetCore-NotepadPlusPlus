using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI.Second_Style;

public partial class FrmRun : Form
{
    #region Constructor

    public FrmRun()
    {
        InitializeComponent();
    }

    #endregion

    private void btnBrowse_Click(object sender, System.EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
            txtFile.Text = openFileDialog.FileName;
    }

    private void btnRun_Click(object sender, System.EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtFile.Text))
            if (File.Exists(txtFile.Text))
            {
                Process.Start(txtFile.Text);
                this.Close();
            }
    }
}