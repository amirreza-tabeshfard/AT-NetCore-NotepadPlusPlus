using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI.Second_Style
{
    public partial class FrmMain : Form
    {
        #region Constructor
        
        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Event(s) ==> Form

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TopPanelLeft.BackgroundImage = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.ImageToByteArray(Resource.Images.PNG.NotePad));
        } 

        #endregion
    }
}