using System;
using System.Drawing;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI.Second_Style;

public partial class FrmFind : Form
{
    #region Field(s)

    private RichTextBox _richtext;

    #endregion

    #region Constructor

    public FrmFind(RichTextBox richtext)
    {
        InitializeComponent();
        _richtext = richtext;
    }

    #endregion

    #region Public Method(s)

    public static void Find(RichTextBox rtb, String word, Color color)
    {
        if (string.IsNullOrEmpty(word))
            return;

        int s_start = rtb.SelectionStart, startIndex = 0, index;
        while ((index = rtb.Text.IndexOf(word, startIndex)) != -1)
        {
            rtb.Select(index, word.Length);
            rtb.SelectionColor = color;
            startIndex = index + word.Length;
        }
        rtb.SelectionStart = s_start;
        rtb.SelectionLength = 0;
        rtb.SelectionColor = Color.Black;
    }

    #endregion

    private void btnFindNext_Click(object sender, EventArgs e)
    {
        Find(_richtext, txtFindWhat.Text, Color.Gray);
    }
}