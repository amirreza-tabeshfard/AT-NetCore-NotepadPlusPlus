using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AT_Notepad.WFA.NetCore.Common.Extensions;
using AT_Notepad.WFA.NetCore.Infrastructure.First_Style;

namespace AT_Notepad.WFA.NetCore.UI.First_Style
{
    public partial class FrmContent : Form
    {
        #region Constructor

        public FrmContent()
        {
            InitializeComponent();
            UpdateStatusBar();
        }

        #endregion

        #region Properties

        public bool NameCondition { get; set; }

        public bool SaveCondition { get; set; }

        #endregion

        #region Private Method(s)

        private int SelectionStart
        {
            get
            {
                return textBox.SelectionStart;
            }
            set
            {
                textBox.SelectionStart = value;
                textBox.ScrollToCaret();
            }
        }

        private ContentPosition CharIndexToPosition(int pCharIndex)
        {
            var CurrentCharIndex = 0;

            if (textBox.Lines.Length == 0 && CurrentCharIndex == 0)
                return new ContentPosition
                {
                    LineIndex = 0,
                    ColumnIndex = 0
                };

            for (var CurrentLineIndex = 0; CurrentLineIndex < textBox.Lines.Length; CurrentLineIndex++)
            {
                var LineStartCharIndex = CurrentCharIndex;
                var Line = textBox.Lines[CurrentLineIndex];
                var LineEndCharIndex = LineStartCharIndex + Line.Length + 1;

                if (pCharIndex >= LineStartCharIndex && pCharIndex <= LineEndCharIndex)
                {
                    var ColumnIndex = pCharIndex - LineStartCharIndex;
                    return new ContentPosition
                    {
                        LineIndex = CurrentLineIndex,
                        ColumnIndex = ColumnIndex
                    };
                }

                CurrentCharIndex += textBox.Lines[CurrentLineIndex].Length + Environment.NewLine.Length;
            }

            return null;
        }

        private ContentPosition CaretPosition
        {
            get
            {
                return CharIndexToPosition(SelectionStart);
            }
        }

        private void UpdateStatusBar()
        {
            if (StatusStripLineColumn.Tag == null)
            {
                StatusStripLineColumn.Tag = StatusStripLineColumn.Text;
            }

            StatusStripLineColumn.Text = ((string)StatusStripLineColumn.Tag).FormatUsingObject(new
            {
                LineNumber = CaretPosition.LineIndex + 1,
                ColumnNumber = CaretPosition.ColumnIndex + 1,
            });
        }

        #endregion

        #region Event(s) ==> Form

        private void FrmContent_Load(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void FrmContent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveCondition is true)
            {
                DialogResult Close;
                Close = MessageBox.Show("The text in the ( Note Pad - " + Text + " ) file has changed.\n\nDo you want to save the changes?", "Note Pad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (Close == DialogResult.Yes)
                    ((FrmMain)MdiParent).MnuFileSaveAs_Click(sender, e);
                else if ((Close == DialogResult.No) || (Close == DialogResult.Cancel))
                    e.Cancel = false;
            }
            else
                e.Cancel = false;
        }

        #endregion

        #region Event(s) ==> textBox

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            SaveCondition = true;
            UpdateStatusBar();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateStatusBar();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateStatusBar();
        }

        private void TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateStatusBar();
        }

        private void TextBox_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateStatusBar();
        }

        #endregion
    }
}