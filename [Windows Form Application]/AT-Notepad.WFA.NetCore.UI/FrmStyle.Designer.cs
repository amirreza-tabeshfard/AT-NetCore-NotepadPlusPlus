
namespace AT_Notepad.WFA.NetCore.UI
{
    partial class FrmStyle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOne
            // 
            this.BtnOne.Location = new System.Drawing.Point(12, 12);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(300, 30);
            this.BtnOne.TabIndex = 0;
            this.BtnOne.Text = "One";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.Location = new System.Drawing.Point(12, 48);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(300, 30);
            this.BtnTwo.TabIndex = 1;
            this.BtnTwo.Text = "Two";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // FrmCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 86);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnOne);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cases";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnTwo;
    }
}