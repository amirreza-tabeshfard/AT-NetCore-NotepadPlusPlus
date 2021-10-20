
namespace AT_Notepad.WFA.NetCore.UI.First_Style
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
            this.lblFindWhat = new System.Windows.Forms.Label();
            this.txtFindWhat = new System.Windows.Forms.TextBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupDirection = new System.Windows.Forms.GroupBox();
            this.radioUp = new System.Windows.Forms.RadioButton();
            this.radioDown = new System.Windows.Forms.RadioButton();
            this.checkBoxMachCase = new System.Windows.Forms.CheckBox();
            this.groupDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFindWhat
            // 
            this.lblFindWhat.AutoSize = true;
            this.lblFindWhat.Location = new System.Drawing.Point(12, 15);
            this.lblFindWhat.Name = "lblFindWhat";
            this.lblFindWhat.Size = new System.Drawing.Size(56, 16);
            this.lblFindWhat.TabIndex = 0;
            this.lblFindWhat.Text = "Fi&nd what:";
            // 
            // txtFindWhat
            // 
            this.txtFindWhat.Location = new System.Drawing.Point(74, 12);
            this.txtFindWhat.Name = "txtFindWhat";
            this.txtFindWhat.Size = new System.Drawing.Size(213, 22);
            this.txtFindWhat.TabIndex = 1;
            this.txtFindWhat.TextChanged += new System.EventHandler(this.TxtFindWhat_TextChanged);
            this.txtFindWhat.Enter += new System.EventHandler(this.TxtFindWhat_Enter);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(293, 12);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "&Find next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.BtnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(293, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupDirection
            // 
            this.groupDirection.Controls.Add(this.radioUp);
            this.groupDirection.Controls.Add(this.radioDown);
            this.groupDirection.Location = new System.Drawing.Point(167, 40);
            this.groupDirection.Name = "groupDirection";
            this.groupDirection.Size = new System.Drawing.Size(120, 47);
            this.groupDirection.TabIndex = 4;
            this.groupDirection.TabStop = false;
            this.groupDirection.Text = "Direction";
            // 
            // radioUp
            // 
            this.radioUp.AutoSize = true;
            this.radioUp.Location = new System.Drawing.Point(6, 21);
            this.radioUp.Name = "radioUp";
            this.radioUp.Size = new System.Drawing.Size(39, 20);
            this.radioUp.TabIndex = 8;
            this.radioUp.TabStop = true;
            this.radioUp.Text = "Up";
            this.radioUp.UseVisualStyleBackColor = true;
            // 
            // radioDown
            // 
            this.radioDown.AutoSize = true;
            this.radioDown.Checked = true;
            this.radioDown.Location = new System.Drawing.Point(61, 21);
            this.radioDown.Name = "radioDown";
            this.radioDown.Size = new System.Drawing.Size(53, 20);
            this.radioDown.TabIndex = 7;
            this.radioDown.TabStop = true;
            this.radioDown.Text = "Down";
            this.radioDown.UseVisualStyleBackColor = true;
            // 
            // checkBoxMachCase
            // 
            this.checkBoxMachCase.AutoSize = true;
            this.checkBoxMachCase.Location = new System.Drawing.Point(12, 67);
            this.checkBoxMachCase.Name = "checkBoxMachCase";
            this.checkBoxMachCase.Size = new System.Drawing.Size(77, 20);
            this.checkBoxMachCase.TabIndex = 5;
            this.checkBoxMachCase.Text = "Mach &case";
            this.checkBoxMachCase.UseVisualStyleBackColor = true;
            // 
            // FrmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 97);
            this.Controls.Add(this.checkBoxMachCase);
            this.Controls.Add(this.groupDirection);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtFindWhat);
            this.Controls.Add(this.lblFindWhat);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFind";
            this.Text = "FrmFind";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFind_FormClosing);
            this.Load += new System.EventHandler(this.FrmFind_Load);
            this.groupDirection.ResumeLayout(false);
            this.groupDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFindWhat;
        private System.Windows.Forms.TextBox txtFindWhat;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupDirection;
        private System.Windows.Forms.RadioButton radioUp;
        private System.Windows.Forms.RadioButton radioDown;
        private System.Windows.Forms.CheckBox checkBoxMachCase;
    }
}