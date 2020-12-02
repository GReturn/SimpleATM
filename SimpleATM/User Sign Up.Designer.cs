namespace SimpleATM
{
    partial class User_Sign_Up
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
            this.components = new System.ComponentModel.Container();
            this.TxtNewUsername = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxtNewPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.RNGPIN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextID = new System.Windows.Forms.TextBox();
            this.BtnNewID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNewUsername
            // 
            this.TxtNewUsername.Location = new System.Drawing.Point(31, 77);
            this.TxtNewUsername.Name = "TxtNewUsername";
            this.TxtNewUsername.Size = new System.Drawing.Size(227, 20);
            this.TxtNewUsername.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TxtNewPIN
            // 
            this.TxtNewPIN.Location = new System.Drawing.Point(31, 114);
            this.TxtNewPIN.Name = "TxtNewPIN";
            this.TxtNewPIN.Size = new System.Drawing.Size(79, 20);
            this.TxtNewPIN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(183, 142);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // RNGPIN
            // 
            this.RNGPIN.Location = new System.Drawing.Point(116, 114);
            this.RNGPIN.Name = "RNGPIN";
            this.RNGPIN.Size = new System.Drawing.Size(142, 20);
            this.RNGPIN.TabIndex = 3;
            this.RNGPIN.Text = "Generate PIN Code";
            this.RNGPIN.UseVisualStyleBackColor = true;
            this.RNGPIN.Click += new System.EventHandler(this.RNGPIN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID No.";
            // 
            // TextID
            // 
            this.TextID.Location = new System.Drawing.Point(31, 38);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(123, 20);
            this.TextID.TabIndex = 5;
            // 
            // BtnNewID
            // 
            this.BtnNewID.Location = new System.Drawing.Point(161, 38);
            this.BtnNewID.Name = "BtnNewID";
            this.BtnNewID.Size = new System.Drawing.Size(97, 23);
            this.BtnNewID.TabIndex = 6;
            this.BtnNewID.Text = "New ID";
            this.BtnNewID.UseVisualStyleBackColor = true;
            this.BtnNewID.Click += new System.EventHandler(this.BtnNewID_Click);
            // 
            // User_Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 187);
            this.Controls.Add(this.BtnNewID);
            this.Controls.Add(this.TextID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RNGPIN);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNewPIN);
            this.Controls.Add(this.TxtNewUsername);
            this.Name = "User_Sign_Up";
            this.Text = "User Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNewUsername;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TxtNewPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button RNGPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.Button BtnNewID;
    }
}