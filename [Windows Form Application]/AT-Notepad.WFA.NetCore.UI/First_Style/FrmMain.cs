using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
    public partial class FrmMain : Form
    {
        #region Field(s)

        private string _lastSearchText;
        private bool _lastMatchCase;
        private bool _lastSearchDown;
        private string _filename;
        private bool _isDirty;

        private StreamReader _streamReader;
        private StreamWriter _streamWriter;

        private OpenFileDialog _openFileDialog;
        private SaveFileDialog _saveFileDialog;
        private FontDialog _fontDialog;
        private ColorDialog _colorDialog;

        private readonly FrmAbout _frmAbout;
        private FrmContent _frmContent;
        private FrmFind _frmFind;
        private FrmReplace _frmReplace;
        private FrmGoTo _frmGoTo;

        #endregion

        #region Constructor

        [Obsolete]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1041:Provide ObsoleteAttribute message", Justification = "<Pending>")]
        public FrmMain()
        {
            InitializeComponent();
            InitializeSetImages();
            InitializeSetOpenFileDialog();
            InitializeSetSaveFileDialog();
            InitializeSetFontDialog();
            InitializeSetColorDialog();
            _frmAbout = new FrmAbout();
        }

        #endregion

        #region Private Properties

        private int SelectionStart
        {
            get
            {
                return ((FrmContent)ActiveMdiChild).textBox.SelectionStart;
            }
            set
            {
                ((FrmContent)ActiveMdiChild).textBox.SelectionStart = value;
                ((FrmContent)ActiveMdiChild).textBox.ScrollToCaret();
            }
        }

        private int SelectionLength
        {
            get
            {
                return ((FrmContent)ActiveMdiChild).textBox.SelectionLength;
            }
            set
            {
                ((FrmContent)ActiveMdiChild).textBox.SelectionLength = value;
            }
        }

        private int SelectionEnd
        {
            get
            {
                return SelectionStart + SelectionLength;
            }
        }

        public string DocumentName
        {
            get
            {
                if (Filename == null)
                    return "Untitled";

                return Path.GetFileName(Filename);
            }
        }

        private string Filename
        {
            get
            {
                return _filename;
            }
            set
            {
                var oldvalue = value;
                _filename = value;
                OnFilenameChanged(oldvalue, value);
            }
        }

        private bool IsDirty
        {
            get
            {
                if (Filename == null && Content.IsEmpty()) 
                    return false;

                return _isDirty;
            }
            set
            {
                _isDirty = value;
            }
        }

        private ContentPosition CaretPosition
        {
            get
            {
                return CharIndexToPosition(SelectionStart);
            }
        }

        private int LineIndex
        {
            get
            {
                return CaretPosition.LineIndex;
            }
            set
            {
                int TargetLineIndex = value;

                if (TargetLineIndex < 0)
                    TargetLineIndex = 0;

                if (TargetLineIndex >= ((FrmContent)ActiveMdiChild).textBox.Lines.Length)
                    TargetLineIndex = ((FrmContent)ActiveMdiChild).textBox.Lines.Length - 1;

                var CharIndex = 0;

                for (var CurrentLineIndex = 0; CurrentLineIndex < TargetLineIndex; CurrentLineIndex++)
                    CharIndex += ((FrmContent)ActiveMdiChild).textBox.Lines[CurrentLineIndex].Length + Environment.NewLine.Length;

                SelectionStart = CharIndex;
                ((FrmContent)ActiveMdiChild).textBox.ScrollToCaret();
            }
        }

        #endregion

        #region Public Properties

        public string Content
        {
            get
            {
                return ((FrmContent)ActiveMdiChild).textBox.Text;
            }
            set
            {
                ((FrmContent)ActiveMdiChild).textBox.Text = value;
            }
        }

        public string SelectedText
        {
            get
            {
                return ((FrmContent)ActiveMdiChild).textBox.SelectedText;
            }
            set
            {
                ((FrmContent)ActiveMdiChild).textBox.SelectedText = value;
                IsDirty = true;
            }
        }

        #endregion

        #region Private Method(s)

        private void InitializeSetImages()
        {
            // Menu File
            MnuFileNew.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.New));
            MnuFileOpen.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Open));
            MnuFileSave.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Save));
            MnuFileSaveAs.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.SaveAs));

            // Menu Edit
            MnuEditUndo.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Undo));
            MnuEditCut.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Cut));
            MnuEditCopy.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Copy));
            MnuEditPaste.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Paste));

            // Menu Help
            MnuHelpAbout.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Info));

            // ToolStrip1
            ToolStrip1New.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.New));
            ToolStrip1Open.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Open));
            ToolStrip1Save.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Save));
            ToolStrip1Cut.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Cut));
            ToolStrip1Copy.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Copy));
            ToolStrip1Paste.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Paste));

            // ToolStrip2
            ToolStrip2Undo.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Undo));

            // ContextMenuStrip1
            ContextMenuStrip1New.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.New));
            ContextMenuStrip1Open.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Open));
            ContextMenuStrip1Save.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Save));
            ContextMenuStrip1Cut.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Cut));
            ContextMenuStrip1Copy.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Copy));
            ContextMenuStrip1Paste.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Paste));

            // MenuStrip2
            ContextMenuStrip2Undo.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Undo));
            ContextMenuStrip2Find.Image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.IconToBytes(Resource.Images.ICO.Search));
        }

        private void InitializeSetOpenFileDialog()
        {
            _openFileDialog = new OpenFileDialog
            {
                Filter = "Text Documents ( *.txt) |*.txt; |All Files ( *.*) |*.*;",
                FileName = "openFileDialog",
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                ReadOnlyChecked = false,
                RestoreDirectory = false,
                ShowHelp = false,
                ShowReadOnly = false,
                SupportMultiDottedExtensions = false,
                ValidateNames = true
            };
        }

        private void InitializeSetSaveFileDialog()
        {
            _saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Documents ( *.txt) |*.txt; |All Files ( *.*) |*.*;",
                FileName = "openFileDialog",
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = false,
                CheckPathExists = true,
                CreatePrompt = false,
                DereferenceLinks = true,
                OverwritePrompt = true,
                RestoreDirectory = false,
                ShowHelp = false,
                SupportMultiDottedExtensions = false,
                ValidateNames = true
            };
        }

        private void InitializeSetFontDialog()
        {
            _fontDialog = new FontDialog
            {
                AllowScriptChange = true,
                AllowSimulations = true,
                AllowVectorFonts = true,
                AllowVerticalFonts = true,
                ScriptsOnly = false,
                ShowApply = false,
                ShowColor = false,
                ShowEffects = false,
                ShowHelp = false
            };
        }

        private void InitializeSetColorDialog()
        {
            _colorDialog = new ColorDialog
            {
                AllowFullOpen = true,
                AnyColor = true,
                FullOpen = true,
                ShowHelp = true,
                SolidColorOnly = true
            };
        }

        private void Find()
        {
            if (Content.Length == 0)
                return;

            if (_frmFind == null)
                _frmFind = new FrmFind(this);

            _frmFind.Left = this.Left + 56;
            _frmFind.Top = this.Top + 160;

            if (!_frmFind.Visible)
                _frmFind.Show(this);
            else
                _frmFind.Show();

            _frmFind.Triggered();
        }

        private void UpdateTitle()
        {
            if (this.Tag == null)
            {
                this.Tag = base.Text;
            }

            base.Text = ((string)this.Tag).FormatUsingObject(new { DocumentName });
        }

        private void OnDocumentNameChanged()
        {
            UpdateTitle();
        }

        private void OnFilenameChanged(string oldvalue, string value)
        {
            if (oldvalue is null)
            {
                throw new ArgumentNullException(nameof(oldvalue));
            }

            OnDocumentNameChanged();
        }

        private ContentPosition CharIndexToPosition(int pCharIndex)
        {
            var CurrentCharIndex = 0;

            if (((FrmContent)ActiveMdiChild).textBox.Lines.Length == 0 && CurrentCharIndex == 0)
                return new ContentPosition
                {
                    LineIndex = 0,
                    ColumnIndex = 0
                };

            for (int CurrentLineIndex = 0; CurrentLineIndex < ((FrmContent)ActiveMdiChild).textBox.Lines.Length; CurrentLineIndex++)
            {
                int LineStartCharIndex = CurrentCharIndex;
                string Line = ((FrmContent)ActiveMdiChild).textBox.Lines[CurrentLineIndex];
                int LineEndCharIndex = LineStartCharIndex + Line.Length + 1;

                if (pCharIndex >= LineStartCharIndex && pCharIndex <= LineEndCharIndex)
                {
                    int ColumnIndex = pCharIndex - LineStartCharIndex;
                    return new ContentPosition
                    {
                        LineIndex = CurrentLineIndex,
                        ColumnIndex = ColumnIndex
                    };
                }

                CurrentCharIndex += ((FrmContent)ActiveMdiChild).textBox.Lines[CurrentLineIndex].Length + Environment.NewLine.Length;
            }

            return null;
        }

        #endregion

        #region Public Method(s)

        public bool FindAndSelect(string pSearchText, bool pMatchCase, bool pSearchDown)
        {
            int Index;

            var eStringComparison = pMatchCase ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;

            if (pSearchDown)
            {
                Index = Content.IndexOf(pSearchText, SelectionEnd, eStringComparison);
            }
            else
            {
                Index = Content.LastIndexOf(pSearchText, SelectionStart, SelectionStart, eStringComparison);
            }

            if (Index == -1)
                return false;

            _lastSearchText = pSearchText;
            _lastMatchCase = pMatchCase;
            _lastSearchDown = pSearchDown;

            SelectionStart = Index;
            SelectionLength = pSearchText.Length;

            return true;
        }

        #endregion

        #region Event(s) ==> Form

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Event(s) ==> Menu File

        [Obsolete]
        private void MnuFileNew_Click(object sender, EventArgs e)
        {
            _frmContent = new();
            _frmContent.MdiParent = this;
            _frmContent.Text = "Note Pad - " + MdiChildren.Length.ToString();
            _frmContent.Show();

            if (File.Exists("FormatConfiguration_Font.bin"))
            {
                FileStream ConfigFile = new("FormatConfiguration_Font.bin", FileMode.Open);
                BinaryFormatter Deserializer = new();
                FormatConfiguration Current = Deserializer.Deserialize(ConfigFile) as FormatConfiguration;
                ConfigFile.Close();
                ((FrmContent)ActiveMdiChild).textBox.Font = Current.CurrentFont;
            }

            if (File.Exists("FormatConfiguration_BackColor.bin"))
            {
                FileStream ConfigFile = new("FormatConfiguration_BackColor.bin", FileMode.Open);
                BinaryFormatter Deserializer = new();
                FormatConfiguration Current = Deserializer.Deserialize(ConfigFile) as FormatConfiguration;
                ConfigFile.Close();
                ((FrmContent)ActiveMdiChild).textBox.BackColor = Current.CurrentColor;
            }

            if (File.Exists("FormatConfiguration_ForeColor.bin"))
            {
                FileStream ConfigFile = new("FormatConfiguration_ForeColor.bin", FileMode.Open);
                BinaryFormatter Deserializer = new();
                FormatConfiguration Current = Deserializer.Deserialize(ConfigFile) as FormatConfiguration;
                ConfigFile.Close();
                ((FrmContent)ActiveMdiChild).textBox.ForeColor = Current.CurrentColor;
            }
        }

        private void MnuFileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (_openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _streamReader = new StreamReader(_openFileDialog.OpenFile());
                    ((FrmContent)ActiveMdiChild).textBox.Text = _streamReader.ReadToEnd();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_streamReader != null)
                    _streamReader.Close();
            }
        }

        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!((FrmContent)ActiveMdiChild).NameCondition)
                    MnuFileSaveAs_Click(sender, e);
                else
                {
                    _streamWriter = new StreamWriter(ActiveMdiChild.Text);
                    _streamWriter.Write(((FrmContent)ActiveMdiChild).textBox.Text);
                    ((FrmContent)ActiveMdiChild).SaveCondition = false;
                    ActiveMdiChild.Text = _saveFileDialog.FileName;
                    ((FrmContent)ActiveMdiChild).NameCondition = true;
                    ((FrmContent)ActiveMdiChild).SaveCondition = false;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_streamWriter != null)
                    _streamWriter.Close();
            }
        }

        internal void MnuFileSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                _saveFileDialog.FileName = ActiveMdiChild.Text;
                if (_saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _streamWriter = new StreamWriter(_saveFileDialog.OpenFile());
                    _streamWriter.Write(((FrmContent)ActiveMdiChild).textBox.Text);
                    ActiveMdiChild.Text = _saveFileDialog.FileName;
                    ((FrmContent)ActiveMdiChild).NameCondition = true;
                    ((FrmContent)ActiveMdiChild).SaveCondition = false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_streamWriter != null)
                    _streamWriter.Close();
            }
        }

        private void MnuFilePrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                PrintDocument.Print();
        }

        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            if (((FrmContent)ActiveMdiChild).NameCondition)
            {
                DialogResult Close;
                Close = MessageBox.Show("The text in the ( Note Pad - " + ActiveMdiChild.Text + " ) file has changed.\n\nDo you want to save the changes?", "Note Pad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (Close == DialogResult.Yes)
                    MnuFileSaveAs_Click(sender, e);
                else if (Close == DialogResult.No)
                    ((FrmContent)ActiveMdiChild).Close();
            }
            else
                ((FrmContent)ActiveMdiChild).Close();
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (((FrmContent)ActiveMdiChild).NameCondition)
                {
                    DialogResult Close;
                    Close = MessageBox.Show("The text in the ( Note Pad - " + ActiveMdiChild.Text + " ) file has changed.\n\nDo you want to save the changes?", "Note Pad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (Close == DialogResult.Yes)
                    {
                        for (int i = 0; i < MdiChildren.Length; i++)
                        {
                            MnuFileSaveAs_Click(sender, e);
                            ((FrmContent)ActiveMdiChild).Close();
                        }
                        Application.Exit();
                    }
                    if (Close == DialogResult.No)
                        Application.Exit();
                }
                else Application.Exit();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Event(s) ==> Menu Edit

        private void MnuEditUndo_Click(object sender, EventArgs e)
        {
            try
            {
                ((FrmContent)ActiveMdiChild).textBox.Undo();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuEditRedo_Click(object sender, EventArgs e)
        {

        }

        private void MnuEditCut_Click(object sender, EventArgs e)
        {
            try
            {
                ((FrmContent)ActiveMdiChild).textBox.Cut();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuEditCopy_Click(object sender, EventArgs e)
        {
            try
            {
                ((FrmContent)ActiveMdiChild).textBox.Copy();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuEditPaste_Click(object sender, EventArgs e)
        {
            try
            {
                ((FrmContent)ActiveMdiChild).textBox.Paste();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuEditDelete_Click(object sender, EventArgs e)
        {

        }

        private void MnuEditFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void MnuEditFindNext_Click(object sender, EventArgs e)
        {
            if (_lastSearchText == null)
            {
                Find();
                return;
            }

            if (!FindAndSelect(_lastSearchText, _lastMatchCase, _lastSearchDown))
            {
                MessageBox.Show(this, CONST.CannotFindMessage.FormatUsingObject(new
                {
                    SearchText = _lastSearchText
                }), "Notepad");
            }
        }

        private void MnuEditReplace_Click(object sender, EventArgs e)
        {
            if (Content.Length == 0)
                return;

            if (_frmReplace == null)
                _frmReplace = new FrmReplace(this);

            _frmReplace.Left = this.Left + 56;
            _frmReplace.Top = this.Top + 113;

            if (!_frmReplace.Visible)
                _frmReplace.Show(this);
            else
                _frmReplace.Show();

            _frmReplace.Triggered();
        }

        private void MnuEditGoTo_Click(object sender, EventArgs e)
        {
            _frmGoTo = new FrmGoTo(LineIndex + 1)
            {
                Left = Left + 5,
                Top = Top + 44
            };

            if (_frmGoTo.ShowDialog(this) != DialogResult.OK) return;

            var TargetLineIndex = _frmGoTo.LineNumber - 1;

            if (TargetLineIndex > ((FrmContent)ActiveMdiChild).textBox.Lines.Length)
            {
                MessageBox.Show(this, "The line number is beyond the total number of lines", "NotepadClone.Net - Goto Line");
                return;
            }

            LineIndex = TargetLineIndex;
        }

        private void MnuEditSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                ((FrmContent)ActiveMdiChild).textBox.SelectAll();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuEditTimeDate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime DT = DateTime.Now;
                ((FrmContent)ActiveMdiChild).textBox.Text += " " + DT.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Event(s) ==> Menu Format

        [Obsolete]
        private void MnuFormatFont_Click(object sender, EventArgs e)
        {
            try
            {
                if (_fontDialog.ShowDialog() == DialogResult.OK)
                {
                    ((FrmContent)ActiveMdiChild).textBox.Font = _fontDialog.Font;
                    FileStream ConfigFile = new("FormatConfiguration_Font.bin", FileMode.Create);
                    BinaryFormatter Serializer = new();
                    Serializer.Serialize(ConfigFile, new FormatConfiguration(_fontDialog.Font));
                    ConfigFile.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [Obsolete]
        private void MnuFormatBackColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (_colorDialog.ShowDialog() == DialogResult.OK)
                {
                    ((FrmContent)ActiveMdiChild).textBox.BackColor = _colorDialog.Color;
                    FileStream ConfigFile = new("FormatConfiguration_BackColor.bin", FileMode.Create);
                    BinaryFormatter Serializer = new();
                    Serializer.Serialize(ConfigFile, new FormatConfiguration(_colorDialog.Color));
                    ConfigFile.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [Obsolete]
        private void MnuFormatForeColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (_colorDialog.ShowDialog() == DialogResult.OK)
                {
                    ((FrmContent)ActiveMdiChild).textBox.ForeColor = _colorDialog.Color;
                    FileStream ConfigFile = new("FormatConfiguration_ForeColor.bin", FileMode.Create);
                    BinaryFormatter Serializer = new();
                    Serializer.Serialize(ConfigFile, new FormatConfiguration(_colorDialog.Color));
                    ConfigFile.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Event(s) ==> Menu View

        private void MnuViewArrangeByCascade_Click(object sender, EventArgs e)
        {
            MnuViewArrangeByCascade.Checked = true;
            MnuViewArrangeByHorizontally.Checked = false;
            MnuViewArrangeByVertically.Checked = false;
            LayoutMdi(MdiLayout.Cascade);
            ToolStrip2ComboArrange.Text = "Cascade";
        }

        private void MnuViewArrangeByHorizontally_Click(object sender, EventArgs e)
        {
            MnuViewArrangeByCascade.Checked = false;
            MnuViewArrangeByHorizontally.Checked = true;
            MnuViewArrangeByVertically.Checked = false;
            LayoutMdi(MdiLayout.TileHorizontal);
            ToolStrip2ComboArrange.Text = "Horizontally";
        }

        private void MnuViewArrangeByVertically_Click(object sender, EventArgs e)
        {
            MnuViewArrangeByCascade.Checked = false;
            MnuViewArrangeByHorizontally.Checked = false;
            MnuViewArrangeByVertically.Checked = true;
            LayoutMdi(MdiLayout.TileVertical);
            ToolStrip2ComboArrange.Text = "Vertically";
        }

        private void MnuViewToolStrip1_Click(object sender, EventArgs e)
        {
            if (MnuViewToolStrip1.Checked == true)
            {
                MnuViewToolStrip1.Checked = false;
                ToolStrip1.Visible = false;
            }
            else if (MnuViewToolStrip1.Checked == false)
            {
                MnuViewToolStrip1.Checked = true;
                ToolStrip1.Visible = true;
            }
        }

        private void MnuViewToolStrip2_Click(object sender, EventArgs e)
        {
            if (MnuViewToolStrip2.Checked == true)
            {
                MnuViewToolStrip2.Checked = false;
                ToolStrip2.Visible = false;
            }
            else if (MnuViewToolStrip2.Checked == false)
            {
                MnuViewToolStrip2.Checked = true;
                ToolStrip2.Visible = true;
            }
        }

        private void MnuViewStatusBar_Click(object sender, EventArgs e)
        {
            if (MnuViewStatusBar.Checked == true)
            {
                MnuViewStatusBar.Checked = false;
                StatusStrip1.Visible = false;
            }
            else if (MnuViewStatusBar.Checked == false)
            {
                MnuViewStatusBar.Checked = true;
                StatusStrip1.Visible = true;
            }
        }

        #endregion

        #region Event(s) ==> Menu Help

        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            _frmAbout.ShowDialog();
        }

        #endregion

        #region Event(s) ==> ToolStrip1

        [Obsolete]
        private void ToolStrip1New_Click(object sender, EventArgs e)
        {
            MnuFileNew_Click(sender, e);
        }

        private void ToolStrip1Open_Click(object sender, EventArgs e)
        {
            MnuFileOpen_Click(sender, e);
        }

        private void ToolStrip1Save_Click(object sender, EventArgs e)
        {
            MnuFileSave_Click(sender, e);
        }

        private void ToolStrip1Cut_Click(object sender, EventArgs e)
        {
            MnuEditCut_Click(sender, e);
        }

        private void ToolStrip1Copy_Click(object sender, EventArgs e)
        {
            MnuEditCopy_Click(sender, e);
        }

        private void ToolStrip1Paste_Click(object sender, EventArgs e)
        {
            MnuEditPaste_Click(sender, e);
        }

        #endregion

        #region Event(s) ==> ToolStrip2

        private void ToolStrip2Undo_Click(object sender, EventArgs e)
        {
            MnuEditUndo_Click(sender, e);
        }

        private void ToolStrip2ComboArrange_Click(object sender, EventArgs e)
        {
            switch (ToolStrip2ComboArrange.Text)
            {
                case "Cascade":
                    {
                        MnuViewArrangeByCascade_Click(sender, e);
                    }
                    break;

                case "Horizontally":
                    {
                        MnuViewArrangeByHorizontally_Click(sender, e);
                    }
                    break;

                case "Vertically":
                    {
                        MnuViewArrangeByVertically_Click(sender, e);
                    }
                    break;
            }
        }

        #endregion

        #region Event(s) ==> ContextMenuStrip1

        private void ContextMenuStrip1New_Click(object sender, EventArgs e)
        {
            if (ContextMenuStrip1New.Checked == true)
            {
                ContextMenuStrip1New.Checked = false;
                ToolStrip1New.Visible = false;
            }
            else if (ContextMenuStrip1New.Checked == false)
            {
                ContextMenuStrip1New.Checked = true;
                ToolStrip1New.Visible = true;
            }
        }

        private void ContextMenuStrip1Open_Click(object sender, EventArgs e)
        {
            if (ContextMenuStrip1Open.Checked == true)
            {
                ContextMenuStrip1Open.Checked = false;
                ToolStrip1Open.Visible = false;
            }
            else if (ContextMenuStrip1Open.Checked == false)
            {
                ContextMenuStrip1Open.Checked = true;
                ToolStrip1Open.Visible = true;
            }
        }

        private void ContextMenuStrip1Save_Click(object sender, EventArgs e)
        {
            if (ContextMenuStrip1Save.Checked == true)
            {
                ContextMenuStrip1Save.Checked = false;
                ToolStrip1Save.Visible = false;
            }
            else if (ContextMenuStrip1Save.Checked == false)
            {
                ContextMenuStrip1Save.Checked = true;
                ToolStrip1Save.Visible = true;
            }
        }

        private void ContextMenuStrip1Cut_Click(object sender, EventArgs e)
        {
            if (ContextMenuStrip1Cut.Checked == true)
            {
                ContextMenuStrip1Cut.Checked = false;
                ToolStrip1Cut.Visible = false;
            }
            else
                if (ContextMenuStrip1Cut.Checked == false)
            {
                ContextMenuStrip1Cut.Checked = true;
                ToolStrip1Cut.Visible = true;
            }
        }

        private void ContextMenuStrip1Copy_Click(object sender, EventArgs e)
        {
            if (ContextMenuStrip1Copy.Checked == true)
            {
                ContextMenuStrip1Copy.Checked = false;
                ToolStrip1Copy.Visible = false;
            }
            else if (ContextMenuStrip1Copy.Checked == false)
            {
                ContextMenuStrip1Copy.Checked = true;
                ToolStrip1Copy.Visible = true;
            }
        }

        private void ContextMenuStrip1Paste_Click(object sender, EventArgs e)
        {
            if (ContextMenuStrip1Paste.Checked == true)
            {
                ContextMenuStrip1Paste.Checked = false;
                ToolStrip1Paste.Visible = false;
            }
            else if (ContextMenuStrip1Paste.Checked == false)
            {
                ContextMenuStrip1Paste.Checked = true;
                ToolStrip1Paste.Visible = true;
            }
        }

        #endregion

        #region Event(s) ==> ContextMenuStrip2

        private void ContextMenuStrip2Find_Click(object sender, EventArgs e)
        {
            if (ContextMenuStrip2Find.Checked == true)
            {
                ContextMenuStrip2Find.Checked = false;
            }
            else if (ContextMenuStrip2Find.Checked == false)
            {
                ContextMenuStrip2Find.Checked = true;
            }
        }

        private void ContextMenuStrip2Undo_Click(object sender, EventArgs e)
        {
            if (ContextMenuStrip2Undo.Checked == true)
            {
                ContextMenuStrip2Undo.Checked = false;
                ToolStrip2Undo.Visible = false;
            }
            else if (ContextMenuStrip2Undo.Checked == false)
            {
                ContextMenuStrip2Undo.Checked = true;
                ToolStrip2Undo.Visible = true;
            }
        }

        private void ContextMenuStrip2ComboArrange_Click(object sender, EventArgs e)
        {
            if (ContextMenuStrip2ComboArrange.Checked == true)
            {
                ContextMenuStrip2ComboArrange.Checked = false;
                ToolStrip2ComboArrange.Visible = false;
            }
            else if (ContextMenuStrip2ComboArrange.Checked == false)
            {
                ContextMenuStrip2ComboArrange.Checked = true;
                ToolStrip2ComboArrange.Visible = true;
            }
        }

        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime Time = DateTime.Now;
            lblTimeStatus.Text = "Timer: " + Time.ToLongTimeString();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(((FrmContent)ActiveMdiChild).textBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }
    }
}