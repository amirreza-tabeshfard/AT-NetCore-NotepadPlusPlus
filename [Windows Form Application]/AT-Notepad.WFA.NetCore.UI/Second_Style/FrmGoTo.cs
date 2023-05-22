using System;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI.Second_Style;

public partial class FrmGoTo : Form
{
    #region Field(s)

    private RichTextBox _richText;

    #endregion

    #region Constructor

    public FrmGoTo(RichTextBox richTextBox)
    {
        InitializeComponent();
        _richText = richTextBox;
    }

    #endregion

    private void FrmGoTo_Load(object sender, EventArgs e)
    {
        int lines = _richText.Lines.Length;
        lblLineNumber.Text = "Enter Line Number (1-" + lines.ToString() + ") :";

        int sel = _richText.GetLineFromCharIndex(_richText.SelectionStart) + 1;
        txtLineNumber.Text = sel.ToString();
    }

    private void txtLineNumber_TextChanged(object sender, EventArgs e)
    {
        int sel;
        RichTextBox rtb = new RichTextBox();
        rtb.Text = _richText.Text;
        int lines = rtb.Lines.Length;

        if (txtLineNumber.Text == string.Empty)
            btnGoTo.Enabled = false;
        else if (!int.TryParse(txtLineNumber.Text, out sel))
            btnGoTo.Enabled = false;
        else if (Int32.Parse(txtLineNumber.Text) > rtb.Lines.Length)
            btnGoTo.Enabled = false;
        else if (txtLineNumber.Text == "0")
            btnGoTo.Enabled = false;
        else
            btnGoTo.Enabled = true;
    }

    private void btnGoTo_Click(object sender, EventArgs e)
    {
        int line = Int32.Parse(txtLineNumber.Text);
        _richText.SelectionStart = _richText.GetFirstCharIndexFromLine(line - 1);
        _richText.ScrollToCaret();
        this.Close();
    }
}