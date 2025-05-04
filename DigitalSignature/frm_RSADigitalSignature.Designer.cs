namespace _3DES.DigitalSignature
{
    partial class frm_RSADigitalSignature
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txtPublickeyInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSavePublickey = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtSignatureFile = new System.Windows.Forms.TextBox();
            this.txtInputFileVerify = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckSignature = new System.Windows.Forms.Button();
            this.btnChoosePublickey = new System.Windows.Forms.Button();
            this.btnChooseSignature = new System.Windows.Forms.Button();
            this.btnOpenFileVerify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateKey);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txtPublickeyInput);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.btnSavePublickey);
            this.groupBox1.Controls.Add(this.btnSign);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.txtInputFile);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Signature";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnGenerateKey.Location = new System.Drawing.Point(737, 136);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(318, 45);
            this.btnGenerateKey.TabIndex = 4;
            this.btnGenerateKey.Text = "Generate key pair";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("MingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(199, 291);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(505, 40);
            this.txt_Email.TabIndex = 3;
            // 
            // txtPublickeyInput
            // 
            this.txtPublickeyInput.Font = new System.Drawing.Font("MingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublickeyInput.Location = new System.Drawing.Point(199, 139);
            this.txtPublickeyInput.Name = "txtPublickeyInput";
            this.txtPublickeyInput.Size = new System.Drawing.Size(505, 40);
            this.txtPublickeyInput.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(737, 290);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(318, 45);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSavePublickey
            // 
            this.btnSavePublickey.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSavePublickey.Location = new System.Drawing.Point(499, 211);
            this.btnSavePublickey.Name = "btnSavePublickey";
            this.btnSavePublickey.Size = new System.Drawing.Size(149, 43);
            this.btnSavePublickey.TabIndex = 2;
            this.btnSavePublickey.Text = "Save Publickey";
            this.btnSavePublickey.UseVisualStyleBackColor = true;
            this.btnSavePublickey.Click += new System.EventHandler(this.btnSavePublickey_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSign.Location = new System.Drawing.Point(338, 211);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(139, 43);
            this.btnSign.TabIndex = 2;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(737, 35);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(318, 45);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtInputFile
            // 
            this.txtInputFile.Font = new System.Drawing.Font("MingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputFile.Location = new System.Drawing.Point(199, 37);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(505, 40);
            this.txtInputFile.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Public key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input file:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.txtPublicKey);
            this.groupBox2.Controls.Add(this.txtSignatureFile);
            this.groupBox2.Controls.Add(this.txtInputFileVerify);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCheckSignature);
            this.groupBox2.Controls.Add(this.btnChoosePublickey);
            this.groupBox2.Controls.Add(this.btnChooseSignature);
            this.groupBox2.Controls.Add(this.btnOpenFileVerify);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 16.2F);
            this.groupBox2.Location = new System.Drawing.Point(12, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1084, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verify a Signature";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_thoat.Location = new System.Drawing.Point(951, 260);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(127, 52);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Font = new System.Drawing.Font("MingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtPublicKey.Location = new System.Drawing.Point(294, 174);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(410, 40);
            this.txtPublicKey.TabIndex = 3;
            // 
            // txtSignatureFile
            // 
            this.txtSignatureFile.Font = new System.Drawing.Font("MingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtSignatureFile.Location = new System.Drawing.Point(294, 133);
            this.txtSignatureFile.Name = "txtSignatureFile";
            this.txtSignatureFile.Size = new System.Drawing.Size(410, 40);
            this.txtSignatureFile.TabIndex = 3;
            // 
            // txtInputFileVerify
            // 
            this.txtInputFileVerify.Font = new System.Drawing.Font("MingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtInputFileVerify.Location = new System.Drawing.Point(294, 66);
            this.txtInputFileVerify.Name = "txtInputFileVerify";
            this.txtInputFileVerify.Size = new System.Drawing.Size(410, 40);
            this.txtInputFileVerify.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Choose file publickey ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose file sign";
            // 
            // btnCheckSignature
            // 
            this.btnCheckSignature.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnCheckSignature.Location = new System.Drawing.Point(147, 256);
            this.btnCheckSignature.Name = "btnCheckSignature";
            this.btnCheckSignature.Size = new System.Drawing.Size(218, 56);
            this.btnCheckSignature.TabIndex = 2;
            this.btnCheckSignature.Text = "Check Sign";
            this.btnCheckSignature.UseVisualStyleBackColor = true;
            this.btnCheckSignature.Click += new System.EventHandler(this.btnCheckSignature_Click);
            // 
            // btnChoosePublickey
            // 
            this.btnChoosePublickey.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnChoosePublickey.Location = new System.Drawing.Point(737, 176);
            this.btnChoosePublickey.Name = "btnChoosePublickey";
            this.btnChoosePublickey.Size = new System.Drawing.Size(318, 45);
            this.btnChoosePublickey.TabIndex = 2;
            this.btnChoosePublickey.Text = "Choose file publickey";
            this.btnChoosePublickey.UseVisualStyleBackColor = true;
            this.btnChoosePublickey.Click += new System.EventHandler(this.btnChoosePublickey_Click);
            // 
            // btnChooseSignature
            // 
            this.btnChooseSignature.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnChooseSignature.Location = new System.Drawing.Point(737, 125);
            this.btnChooseSignature.Name = "btnChooseSignature";
            this.btnChooseSignature.Size = new System.Drawing.Size(318, 45);
            this.btnChooseSignature.TabIndex = 2;
            this.btnChooseSignature.Text = "Choose file sign";
            this.btnChooseSignature.UseVisualStyleBackColor = true;
            this.btnChooseSignature.Click += new System.EventHandler(this.btnChooseSignature_Click);
            // 
            // btnOpenFileVerify
            // 
            this.btnOpenFileVerify.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnOpenFileVerify.Location = new System.Drawing.Point(737, 64);
            this.btnOpenFileVerify.Name = "btnOpenFileVerify";
            this.btnOpenFileVerify.Size = new System.Drawing.Size(318, 45);
            this.btnOpenFileVerify.TabIndex = 2;
            this.btnOpenFileVerify.Text = "Open file";
            this.btnOpenFileVerify.UseVisualStyleBackColor = true;
            this.btnOpenFileVerify.Click += new System.EventHandler(this.btnOpenFileVerify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input file:";
            // 
            // frm_RSADigitalSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 708);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_RSADigitalSignature";
            this.Text = "frm_RSADigitalSignature";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPublickeyInput;
        private System.Windows.Forms.Button btnSavePublickey;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSignatureFile;
        private System.Windows.Forms.TextBox txtInputFileVerify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckSignature;
        private System.Windows.Forms.Button btnChooseSignature;
        private System.Windows.Forms.Button btnOpenFileVerify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChoosePublickey;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_thoat;
    }
}