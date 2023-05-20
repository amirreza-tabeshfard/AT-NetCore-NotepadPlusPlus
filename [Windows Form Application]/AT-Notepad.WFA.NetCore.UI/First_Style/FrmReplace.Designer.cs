
namespace AT_Notepad.WFA.NetCore.UI.First_Style
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
            btnFindNext = new System.Windows.Forms.Button();
            txtFindWhat = new System.Windows.Forms.TextBox();
            lblFindWhat = new System.Windows.Forms.Label();
            txtReplaceWith = new System.Windows.Forms.TextBox();
            lblReplaceWith = new System.Windows.Forms.Label();
            btnReplace = new System.Windows.Forms.Button();
            btnReplaceAll = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            checkBoxMachCase = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // btnFindNext
            // 
            btnFindNext.Location = new System.Drawing.Point(305, 12);
            btnFindNext.Name = "btnFindNext";
            btnFindNext.Size = new System.Drawing.Size(75, 23);
            btnFindNext.TabIndex = 5;
            btnFindNext.Text = "&Find next";
            btnFindNext.UseVisualStyleBackColor = true;
            btnFindNext.Click += BtnFindNext_Click;
            // 
            // txtFindWhat
            // 
            txtFindWhat.Location = new System.Drawing.Point(88, 13);
            txtFindWhat.Name = "txtFindWhat";
            txtFindWhat.Size = new System.Drawing.Size(211, 22);
            txtFindWhat.TabIndex = 4;
            txtFindWhat.TextChanged += TxtFindWhat_TextChanged;
            txtFindWhat.Enter += TxtFindWhat_Enter;
            // 
            // lblFindWhat
            // 
            lblFindWhat.AutoSize = true;
            lblFindWhat.Location = new System.Drawing.Point(12, 15);
            lblFindWhat.Name = "lblFindWhat";
            lblFindWhat.Size = new System.Drawing.Size(56, 16);
            lblFindWhat.TabIndex = 3;
            lblFindWhat.Text = "Fi&nd what:";
            // 
            // txtReplaceWith
            // 
            txtReplaceWith.Location = new System.Drawing.Point(88, 41);
            txtReplaceWith.Name = "txtReplaceWith";
            txtReplaceWith.Size = new System.Drawing.Size(211, 22);
            txtReplaceWith.TabIndex = 7;
            txtReplaceWith.Enter += TxtReplaceWith_Enter;
            // 
            // lblReplaceWith
            // 
            lblReplaceWith.AutoSize = true;
            lblReplaceWith.Location = new System.Drawing.Point(12, 43);
            lblReplaceWith.Name = "lblReplaceWith";
            lblReplaceWith.Size = new System.Drawing.Size(70, 16);
            lblReplaceWith.TabIndex = 6;
            lblReplaceWith.Text = "Re&place with:";
            // 
            // btnReplace
            // 
            btnReplace.Location = new System.Drawing.Point(305, 41);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new System.Drawing.Size(75, 23);
            btnReplace.TabIndex = 8;
            btnReplace.Text = "&Replace";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += BtnReplace_Click;
            // 
            // btnReplaceAll
            // 
            btnReplaceAll.Location = new System.Drawing.Point(305, 70);
            btnReplaceAll.Name = "btnReplaceAll";
            btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            btnReplaceAll.TabIndex = 9;
            btnReplaceAll.Text = "Replace &All";
            btnReplaceAll.UseVisualStyleBackColor = true;
            btnReplaceAll.Click += BtnReplaceAll_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(305, 99);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // checkBoxMachCase
            // 
            checkBoxMachCase.AutoSize = true;
            checkBoxMachCase.Location = new System.Drawing.Point(12, 101);
            checkBoxMachCase.Name = "checkBoxMachCase";
            checkBoxMachCase.Size = new System.Drawing.Size(77, 20);
            checkBoxMachCase.TabIndex = 11;
            checkBoxMachCase.Text = "Mach &case";
            checkBoxMachCase.UseVisualStyleBackColor = true;
            // 
            // FrmReplace
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(390, 127);
            Controls.Add(checkBoxMachCase);
            Controls.Add(btnCancel);
            Controls.Add(btnReplaceAll);
            Controls.Add(btnReplace);
            Controls.Add(txtReplaceWith);
            Controls.Add(lblReplaceWith);
            Controls.Add(btnFindNext);
            Controls.Add(txtFindWhat);
            Controls.Add(lblFindWhat);
            Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmReplace";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Replace";
            FormClosing += FrmReplace_FormClosing;
            Load += FrmReplace_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.TextBox txtFindWhat;
        private System.Windows.Forms.Label lblFindWhat;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Label lblReplaceWith;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxMachCase;
    }
}