namespace AT_Notepad.WFA.NetCore.UI.Second_Style
{
    partial class FrmGoTo
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
            components = new System.ComponentModel.Container();
            btnGoTo = new System.Windows.Forms.Button();
            txtLineNumber = new System.Windows.Forms.TextBox();
            lblLineNumber = new System.Windows.Forms.Label();
            toolTip = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // btnGoTo
            // 
            btnGoTo.Location = new System.Drawing.Point(157, 57);
            btnGoTo.Name = "btnGoTo";
            btnGoTo.Size = new System.Drawing.Size(75, 23);
            btnGoTo.TabIndex = 7;
            btnGoTo.Text = "Go To";
            btnGoTo.UseVisualStyleBackColor = true;
            btnGoTo.Click += btnGoTo_Click;
            // 
            // txtLineNumber
            // 
            txtLineNumber.Location = new System.Drawing.Point(12, 29);
            txtLineNumber.Name = "txtLineNumber";
            txtLineNumber.Size = new System.Drawing.Size(220, 22);
            txtLineNumber.TabIndex = 5;
            txtLineNumber.TextChanged += txtLineNumber_TextChanged;
            // 
            // lblLineNumber
            // 
            lblLineNumber.AutoSize = true;
            lblLineNumber.Location = new System.Drawing.Point(12, 10);
            lblLineNumber.Name = "lblLineNumber";
            lblLineNumber.Size = new System.Drawing.Size(69, 16);
            lblLineNumber.TabIndex = 4;
            lblLineNumber.Text = "&Line number:";
            // 
            // FrmGoTo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(244, 91);
            Controls.Add(btnGoTo);
            Controls.Add(txtLineNumber);
            Controls.Add(lblLineNumber);
            Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGoTo";
            Text = "GoTo";
            Load += FrmGoTo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.TextBox txtLineNumber;
        private System.Windows.Forms.Label lblLineNumber;
        private System.Windows.Forms.ToolTip toolTip;
    }
}