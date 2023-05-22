namespace AT_Notepad.WFA.NetCore.UI.Second_Style
{
    partial class FrmReplace
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
            btnReplaceAll = new System.Windows.Forms.Button();
            txtReplaceWith = new System.Windows.Forms.TextBox();
            lblReplaceWith = new System.Windows.Forms.Label();
            txtFindWhat = new System.Windows.Forms.TextBox();
            lblFindWhat = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnReplaceAll
            // 
            btnReplaceAll.Location = new System.Drawing.Point(12, 92);
            btnReplaceAll.Name = "btnReplaceAll";
            btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            btnReplaceAll.TabIndex = 18;
            btnReplaceAll.Text = "Replace &All";
            btnReplaceAll.UseVisualStyleBackColor = true;
            btnReplaceAll.Click += btnReplaceAll_Click;
            // 
            // txtReplaceWith
            // 
            txtReplaceWith.Location = new System.Drawing.Point(87, 37);
            txtReplaceWith.Name = "txtReplaceWith";
            txtReplaceWith.Size = new System.Drawing.Size(291, 22);
            txtReplaceWith.TabIndex = 16;
            // 
            // lblReplaceWith
            // 
            lblReplaceWith.AutoSize = true;
            lblReplaceWith.Location = new System.Drawing.Point(11, 39);
            lblReplaceWith.Name = "lblReplaceWith";
            lblReplaceWith.Size = new System.Drawing.Size(70, 16);
            lblReplaceWith.TabIndex = 15;
            lblReplaceWith.Text = "Re&place with:";
            // 
            // txtFindWhat
            // 
            txtFindWhat.Location = new System.Drawing.Point(87, 9);
            txtFindWhat.Name = "txtFindWhat";
            txtFindWhat.Size = new System.Drawing.Size(291, 22);
            txtFindWhat.TabIndex = 13;
            // 
            // lblFindWhat
            // 
            lblFindWhat.AutoSize = true;
            lblFindWhat.Location = new System.Drawing.Point(11, 11);
            lblFindWhat.Name = "lblFindWhat";
            lblFindWhat.Size = new System.Drawing.Size(56, 16);
            lblFindWhat.TabIndex = 12;
            lblFindWhat.Text = "Fi&nd what:";
            // 
            // FrmReplace
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(390, 127);
            Controls.Add(btnReplaceAll);
            Controls.Add(txtReplaceWith);
            Controls.Add(lblReplaceWith);
            Controls.Add(txtFindWhat);
            Controls.Add(lblFindWhat);
            Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmReplace";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Replace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Label lblReplaceWith;
        private System.Windows.Forms.TextBox txtFindWhat;
        private System.Windows.Forms.Label lblFindWhat;
    }
}