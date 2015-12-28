namespace SecurityHW3
{
    partial class frmMain
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
            this.lblKey = new System.Windows.Forms.Label();
            this.lblChars = new System.Windows.Forms.Label();
            this.lblCipher = new System.Windows.Forms.Label();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.lblPlain = new System.Windows.Forms.Label();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtChars = new System.Windows.Forms.TextBox();
            this.btnCrackCipher = new System.Windows.Forms.Button();
            this.btnCreateCipher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(16, 9);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(28, 13);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Key:";
            // 
            // lblChars
            // 
            this.lblChars.AutoSize = true;
            this.lblChars.Location = new System.Drawing.Point(16, 31);
            this.lblChars.Name = "lblChars";
            this.lblChars.Size = new System.Drawing.Size(88, 13);
            this.lblChars.TabIndex = 2;
            this.lblChars.Text = "Used characters:";
            // 
            // lblCipher
            // 
            this.lblCipher.AutoSize = true;
            this.lblCipher.Location = new System.Drawing.Point(16, 53);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(57, 13);
            this.lblCipher.TabIndex = 4;
            this.lblCipher.Text = "Ciphertext:";
            // 
            // txtCipher
            // 
            this.txtCipher.Location = new System.Drawing.Point(19, 75);
            this.txtCipher.Multiline = true;
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCipher.Size = new System.Drawing.Size(545, 92);
            this.txtCipher.TabIndex = 5;
            // 
            // lblPlain
            // 
            this.lblPlain.AutoSize = true;
            this.lblPlain.Location = new System.Drawing.Point(16, 176);
            this.lblPlain.Name = "lblPlain";
            this.lblPlain.Size = new System.Drawing.Size(50, 13);
            this.lblPlain.TabIndex = 6;
            this.lblPlain.Text = "Plaintext:";
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(19, 198);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlain.Size = new System.Drawing.Size(545, 92);
            this.txtPlain.TabIndex = 7;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(50, 6);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(510, 20);
            this.txtKey.TabIndex = 1;
            // 
            // txtChars
            // 
            this.txtChars.Location = new System.Drawing.Point(110, 28);
            this.txtChars.Name = "txtChars";
            this.txtChars.Size = new System.Drawing.Size(450, 20);
            this.txtChars.TabIndex = 3;
            this.txtChars.Text = " ,!?.0123456789AĀBCČDEĒFGĢHḨIĪYJKĶLĻMNŅOŌPQRŖSŠTUŪVWXZŽ";
            // 
            // btnCrackCipher
            // 
            this.btnCrackCipher.Location = new System.Drawing.Point(460, 171);
            this.btnCrackCipher.Name = "btnCrackCipher";
            this.btnCrackCipher.Size = new System.Drawing.Size(104, 23);
            this.btnCrackCipher.TabIndex = 8;
            this.btnCrackCipher.Text = "Crack da\' Cipher";
            this.btnCrackCipher.UseVisualStyleBackColor = true;
            this.btnCrackCipher.Click += new System.EventHandler(this.btnCrackCipher_Click);
            // 
            // btnCreateCipher
            // 
            this.btnCreateCipher.Location = new System.Drawing.Point(350, 171);
            this.btnCreateCipher.Name = "btnCreateCipher";
            this.btnCreateCipher.Size = new System.Drawing.Size(104, 23);
            this.btnCreateCipher.TabIndex = 9;
            this.btnCreateCipher.Text = "Create da\' Cipher";
            this.btnCreateCipher.UseVisualStyleBackColor = true;
            this.btnCreateCipher.Click += new System.EventHandler(this.btnCreateCipher_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 304);
            this.Controls.Add(this.btnCreateCipher);
            this.Controls.Add(this.btnCrackCipher);
            this.Controls.Add(this.txtChars);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.lblPlain);
            this.Controls.Add(this.lblCipher);
            this.Controls.Add(this.lblChars);
            this.Controls.Add(this.lblKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Vigenere cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblChars;
        private System.Windows.Forms.Label lblCipher;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Label lblPlain;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtChars;
        private System.Windows.Forms.Button btnCrackCipher;
        private System.Windows.Forms.Button btnCreateCipher;
    }
}

