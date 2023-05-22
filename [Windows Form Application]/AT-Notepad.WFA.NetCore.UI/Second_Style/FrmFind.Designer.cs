namespace AT_Notepad.WFA.NetCore.UI.Second_Style
{
    partial class FrmFind
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
            btnFindNext = new System.Windows.Forms.Button();
            txtFindWhat = new System.Windows.Forms.TextBox();
            lblFindWhat = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnFindNext
            // 
            btnFindNext.Location = new System.Drawing.Point(12, 62);
            btnFindNext.Name = "btnFindNext";
            btnFindNext.Size = new System.Drawing.Size(75, 23);
            btnFindNext.TabIndex = 8;
            btnFindNext.Text = "&Find next";
            btnFindNext.UseVisualStyleBackColor = true;
            btnFindNext.Click += btnFindNext_Click;
            // 
            // txtFindWhat
            // 
            txtFindWhat.Location = new System.Drawing.Point(74, 11);
            txtFindWhat.Name = "txtFindWhat";
            txtFindWhat.Size = new System.Drawing.Size(294, 22);
            txtFindWhat.TabIndex = 7;
            // 
            // lblFindWhat
            // 
            lblFindWhat.AutoSize = true;
            lblFindWhat.Location = new System.Drawing.Point(12, 14);
            lblFindWhat.Name = "lblFindWhat";
            lblFindWhat.Size = new System.Drawing.Size(56, 16);
            lblFindWhat.TabIndex = 6;
            lblFindWhat.Text = "Fi&nd what:";
            // 
            // FrmFind
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(380, 97);
            Controls.Add(btnFindNext);
            Controls.Add(txtFindWhat);
            Controls.Add(lblFindWhat);
            Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFind";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Find";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.TextBox txtFindWhat;
        private System.Windows.Forms.Label lblFindWhat;
    }
}