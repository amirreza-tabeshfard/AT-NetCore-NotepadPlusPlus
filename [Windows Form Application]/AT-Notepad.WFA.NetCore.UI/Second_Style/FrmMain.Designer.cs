
namespace AT_Notepad.WFA.NetCore.UI.Second_Style
{
    partial class FrmMain
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BtnMinimum = new AT_Notepad.WFA.NetCore.UC.Second_Style.CloseAndMinimumControls();
            this.BtnMaximum = new AT_Notepad.WFA.NetCore.UC.Second_Style.MinMaxButtonControls();
            this.BtnClose = new AT_Notepad.WFA.NetCore.UC.Second_Style.CloseAndMinimumControls();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPanelLeft = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanel.Controls.Add(this.BtnMinimum);
            this.TopPanel.Controls.Add(this.BtnMaximum);
            this.TopPanel.Controls.Add(this.BtnClose);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.TopPanelLeft);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 30);
            this.TopPanel.TabIndex = 0;
            // 
            // BtnMinimum
            // 
            this.BtnMinimum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimum.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnMinimum.DisplayText = "_";
            this.BtnMinimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimum.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMinimum.ForeColor = System.Drawing.Color.White;
            this.BtnMinimum.Location = new System.Drawing.Point(692, 3);
            this.BtnMinimum.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnMinimum.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnMinimum.Name = "BtnMinimum";
            this.BtnMinimum.Size = new System.Drawing.Size(31, 24);
            this.BtnMinimum.TabIndex = 4;
            this.BtnMinimum.Text = "_";
            this.BtnMinimum.TextLocation_X = 6;
            this.BtnMinimum.TextLocation_Y = -12;
            this.BtnMinimum.UseVisualStyleBackColor = true;
            // 
            // BtnMaximum
            // 
            this.BtnMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximum.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnMaximum.CFormState = AT_Notepad.WFA.NetCore.Common.Enums.CustomFormState.Normal;
            this.BtnMaximum.DisplayText = "_";
            this.BtnMaximum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximum.ForeColor = System.Drawing.Color.White;
            this.BtnMaximum.Location = new System.Drawing.Point(729, 3);
            this.BtnMaximum.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnMaximum.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnMaximum.Name = "BtnMaximum";
            this.BtnMaximum.Size = new System.Drawing.Size(31, 24);
            this.BtnMaximum.TabIndex = 3;
            this.BtnMaximum.Text = "_";
            this.BtnMaximum.TextLocation_X = 8;
            this.BtnMaximum.TextLocation_Y = 7;
            this.BtnMaximum.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnClose.DisplayText = "X";
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(766, 3);
            this.BtnClose.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnClose.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 24);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "X";
            this.BtnClose.TextLocation_X = 6;
            this.BtnClose.TextLocation_Y = -1;
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notepad ( Style 2 )";
            // 
            // TopPanelLeft
            // 
            this.TopPanelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.TopPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.TopPanelLeft.Name = "TopPanelLeft";
            this.TopPanelLeft.Size = new System.Drawing.Size(30, 30);
            this.TopPanelLeft.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel TopPanelLeft;
        private System.Windows.Forms.Label label1;
        private UC.Second_Style.CloseAndMinimumControls BtnClose;
        private UC.Second_Style.MinMaxButtonControls BtnMaximum;
        private UC.Second_Style.CloseAndMinimumControls BtnMinimum;
    }
}