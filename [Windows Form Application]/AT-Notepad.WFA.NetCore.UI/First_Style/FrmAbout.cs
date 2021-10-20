using System;
using System.Reflection;
using System.Windows.Forms;

namespace AT_Notepad.WFA.NetCore.UI.First_Style
{
    partial class FrmAbout : Form
    {
        readonly Random random;

        [Obsolete]
        public FrmAbout()
        {
            random = new Random();
            InitializeComponent();
            Text = string.Format("About {0}", arg0: AssemblyTitle);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        [Obsolete]
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public static string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            System.Drawing.Image image = default;

            switch (random.Next(1, 7))
            {
                case 1:
                    {
                        image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.ImageToByteArray(Resource.Images.PNG.Logo_01));
                    }
                    break;

                case 2:
                    {
                        image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.ImageToByteArray(Resource.Images.PNG.Logo_02));
                    }
                    break;

                case 3:
                    {
                        image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.ImageToByteArray(Resource.Images.PNG.Logo_03));
                    }
                    break;

                case 4:
                    {
                        image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.ImageToByteArray(Resource.Images.PNG.Logo_04));
                    }
                    break;

                case 5:
                    {
                        image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.ImageToByteArray(Resource.Images.PNG.Logo_05));
                    }
                    break;

                case 6:
                    {
                        image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.ImageToByteArray(Resource.Images.PNG.Logo_06));
                    }
                    break;

                case 7:
                    {
                        image = Common.Extensions.ImageExtensions.ToImage(Common.Extensions.ImageExtensions.ImageToByteArray(Resource.Images.PNG.Logo_07));
                    }
                    break;
            }

            logoPictureBox.Image = image;
        }
    }
}