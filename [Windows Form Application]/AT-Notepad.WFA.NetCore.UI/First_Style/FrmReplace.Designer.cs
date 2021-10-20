
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
            this.btnFindNext = new System.Windows.Forms.Button();
            this.txtFindWhat = new System.Windows.Forms.TextBox();
            this.lblFindWhat = new System.Windows.Forms.Label();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.lblReplaceWith = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxMachCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(305, 12);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 5;
            this.btnFindNext.Text = "&Find next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.BtnFindNext_Click);
            // 
            // txtFindWhat
            // 
            this.txtFindWhat.Location = new System.Drawing.Point(88, 13);
            this.txtFindWhat.Name = "txtFindWhat";
            this.txtFindWhat.Size = new System.Drawing.Size(211, 22);
            this.txtFindWhat.TabIndex = 4;
            this.txtFindWhat.TextChanged += new System.EventHandler(this.TxtFindWhat_TextChanged);
            this.txtFindWhat.Enter += new System.EventHandler(this.TxtFindWhat_Enter);
            // 
            // lblFindWhat
            // 
            this.lblFindWhat.AutoSize = true;
            this.lblFindWhat.Location = new System.Drawing.Point(12, 15);
            this.lblFindWhat.Name = "lblFindWhat";
            this.lblFindWhat.Size = new System.Drawing.Size(56, 16);
            this.lblFindWhat.TabIndex = 3;
            this.lblFindWhat.Text = "Fi&nd what:";
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(88, 41);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(211, 22);
            this.txtReplaceWith.TabIndex = 7;
            this.txtReplaceWith.Enter += new System.EventHandler(this.TxtReplaceWith_Enter);
            // 
            // lblReplaceWith
            // 
            this.lblReplaceWith.AutoSize = true;
            this.lblReplaceWith.Location = new System.Drawing.Point(12, 43);
            this.lblReplaceWith.Name = "lblReplaceWith";
            this.lblReplaceWith.Size = new System.Drawing.Size(70, 16);
            this.lblReplaceWith.TabIndex = 6;
            this.lblReplaceWith.Text = "Re&place with:";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(305, 41);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 8;
            this.btnReplace.Text = "&Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(305, 70);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceAll.TabIndex = 9;
            this.btnReplaceAll.Text = "Replace &All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.BtnReplaceAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(305, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // checkBoxMachCase
            // 
            this.checkBoxMachCase.AutoSize = true;
            this.checkBoxMachCase.Location = new System.Drawing.Point(12, 101);
            this.checkBoxMachCase.Name = "checkBoxMachCase";
            this.checkBoxMachCase.Size = new System.Drawing.Size(77, 20);
            this.checkBoxMachCase.TabIndex = 11;
            this.checkBoxMachCase.Text = "Mach &case";
            this.checkBoxMachCase.UseVisualStyleBackColor = true;
            // 
            // FrmReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 127);
            this.Controls.Add(this.checkBoxMachCase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.lblReplaceWith);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtFindWhat);
            this.Controls.Add(this.lblFindWhat);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReplace_FormClosing);
            this.Load += new System.EventHandler(this.FrmReplace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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