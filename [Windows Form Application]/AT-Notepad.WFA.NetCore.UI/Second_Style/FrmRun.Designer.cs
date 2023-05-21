namespace AT_Notepad.WFA.NetCore.UI.Second_Style
{
    partial class FrmRun
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
            btnRun = new System.Windows.Forms.Button();
            btnBrowse = new System.Windows.Forms.Button();
            txtFile = new System.Windows.Forms.TextBox();
            lblSelectProgram = new System.Windows.Forms.Label();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new System.Drawing.Point(12, 93);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(75, 23);
            btnRun.TabIndex = 16;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(332, 28);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(46, 23);
            btnBrowse.TabIndex = 15;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFile
            // 
            txtFile.Location = new System.Drawing.Point(12, 29);
            txtFile.Name = "txtFile";
            txtFile.Size = new System.Drawing.Size(314, 22);
            txtFile.TabIndex = 14;
            // 
            // lblSelectProgram
            // 
            lblSelectProgram.AutoSize = true;
            lblSelectProgram.Location = new System.Drawing.Point(12, 10);
            lblSelectProgram.Name = "lblSelectProgram";
            lblSelectProgram.Size = new System.Drawing.Size(79, 16);
            lblSelectProgram.TabIndex = 13;
            lblSelectProgram.Text = "Select Program";
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "exe,com,cmd,bat file|*.exe; *.com; *.cmd; *.bat";
            // 
            // FrmRun
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(390, 127);
            Controls.Add(btnRun);
            Controls.Add(btnBrowse);
            Controls.Add(txtFile);
            Controls.Add(lblSelectProgram);
            Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRun";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Run";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblSelectProgram;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}