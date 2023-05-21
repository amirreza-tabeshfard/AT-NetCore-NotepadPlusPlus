namespace AT_Notepad.WFA.NetCore.UI.Second_Style
{
    partial class FrmRunInBrowser
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
            lblFindWhat = new System.Windows.Forms.Label();
            txtBrowser = new System.Windows.Forms.TextBox();
            btnBrowse = new System.Windows.Forms.Button();
            btnRun = new System.Windows.Forms.Button();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // lblFindWhat
            // 
            lblFindWhat.AutoSize = true;
            lblFindWhat.Location = new System.Drawing.Point(12, 9);
            lblFindWhat.Name = "lblFindWhat";
            lblFindWhat.Size = new System.Drawing.Size(78, 16);
            lblFindWhat.TabIndex = 4;
            lblFindWhat.Text = "Select Browser";
            // 
            // txtBrowser
            // 
            txtBrowser.Location = new System.Drawing.Point(12, 28);
            txtBrowser.Name = "txtBrowser";
            txtBrowser.Size = new System.Drawing.Size(314, 22);
            txtBrowser.TabIndex = 5;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(332, 27);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(46, 23);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRun
            // 
            btnRun.Location = new System.Drawing.Point(12, 92);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(75, 23);
            btnRun.TabIndex = 12;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "exe files|*.exe";
            // 
            // FormRunInBrowser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(390, 127);
            Controls.Add(btnRun);
            Controls.Add(btnBrowse);
            Controls.Add(txtBrowser);
            Controls.Add(lblFindWhat);
            Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRunInBrowser";
            Text = "FormRunInBrowser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblFindWhat;
        private System.Windows.Forms.TextBox txtBrowser;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}