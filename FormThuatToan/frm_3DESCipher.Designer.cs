namespace _3DES.FormThuatToan
{
    partial class frm_3DESCipher
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
            this.lbl_3des = new System.Windows.Forms.Label();
            this.lbl_Plaintext = new System.Windows.Forms.Label();
            this.lbl_key = new System.Windows.Forms.Label();
            this.lbl_ciphertext = new System.Windows.Forms.Label();
            this.txt_Plaintext = new System.Windows.Forms.TextBox();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.txt_Ciphertext = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_SavetoFile = new System.Windows.Forms.Button();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_scananh = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_3des
            // 
            this.lbl_3des.AutoSize = true;
            this.lbl_3des.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_3des.Location = new System.Drawing.Point(176, 24);
            this.lbl_3des.Name = "lbl_3des";
            this.lbl_3des.Size = new System.Drawing.Size(683, 62);
            this.lbl_3des.TabIndex = 0;
            this.lbl_3des.Text = "Triple DES Cipher Demo ";
            // 
            // lbl_Plaintext
            // 
            this.lbl_Plaintext.AutoSize = true;
            this.lbl_Plaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Plaintext.Location = new System.Drawing.Point(29, 118);
            this.lbl_Plaintext.Name = "lbl_Plaintext";
            this.lbl_Plaintext.Size = new System.Drawing.Size(95, 25);
            this.lbl_Plaintext.TabIndex = 1;
            this.lbl_Plaintext.Text = "Plaintext";
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_key.Location = new System.Drawing.Point(29, 234);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(50, 25);
            this.lbl_key.TabIndex = 2;
            this.lbl_key.Text = "Key";
            // 
            // lbl_ciphertext
            // 
            this.lbl_ciphertext.AutoSize = true;
            this.lbl_ciphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ciphertext.Location = new System.Drawing.Point(26, 300);
            this.lbl_ciphertext.Name = "lbl_ciphertext";
            this.lbl_ciphertext.Size = new System.Drawing.Size(111, 25);
            this.lbl_ciphertext.TabIndex = 3;
            this.lbl_ciphertext.Text = "Ciphertext";
            // 
            // txt_Plaintext
            // 
            this.txt_Plaintext.Font = new System.Drawing.Font("NSimSun", 13.8F);
            this.txt_Plaintext.Location = new System.Drawing.Point(187, 118);
            this.txt_Plaintext.Multiline = true;
            this.txt_Plaintext.Name = "txt_Plaintext";
            this.txt_Plaintext.Size = new System.Drawing.Size(709, 91);
            this.txt_Plaintext.TabIndex = 4;
            // 
            // txt_Key
            // 
            this.txt_Key.Font = new System.Drawing.Font("NSimSun", 13.8F);
            this.txt_Key.Location = new System.Drawing.Point(187, 237);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(709, 34);
            this.txt_Key.TabIndex = 5;
            // 
            // txt_Ciphertext
            // 
            this.txt_Ciphertext.Font = new System.Drawing.Font("NSimSun", 13.8F);
            this.txt_Ciphertext.Location = new System.Drawing.Point(187, 300);
            this.txt_Ciphertext.Multiline = true;
            this.txt_Ciphertext.Name = "txt_Ciphertext";
            this.txt_Ciphertext.Size = new System.Drawing.Size(709, 91);
            this.txt_Ciphertext.TabIndex = 6;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encrypt.Location = new System.Drawing.Point(203, 410);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(123, 55);
            this.btn_Encrypt.TabIndex = 7;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decrypt.Location = new System.Drawing.Point(332, 410);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(130, 55);
            this.btn_Decrypt.TabIndex = 8;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_SavetoFile
            // 
            this.btn_SavetoFile.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SavetoFile.Location = new System.Drawing.Point(481, 410);
            this.btn_SavetoFile.Name = "btn_SavetoFile";
            this.btn_SavetoFile.Size = new System.Drawing.Size(200, 55);
            this.btn_SavetoFile.TabIndex = 9;
            this.btn_SavetoFile.Text = "Save to File";
            this.btn_SavetoFile.UseVisualStyleBackColor = true;
            this.btn_SavetoFile.Click += new System.EventHandler(this.btn_SavetoFile_Click);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenFile.Location = new System.Drawing.Point(687, 410);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(155, 55);
            this.btn_OpenFile.TabIndex = 10;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_scananh
            // 
            this.btn_scananh.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scananh.Location = new System.Drawing.Point(902, 118);
            this.btn_scananh.Name = "btn_scananh";
            this.btn_scananh.Size = new System.Drawing.Size(142, 91);
            this.btn_scananh.TabIndex = 11;
            this.btn_scananh.Text = "Scan plaintext";
            this.btn_scananh.UseVisualStyleBackColor = true;
            this.btn_scananh.Click += new System.EventHandler(this.btn_scananh_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(905, 410);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(125, 55);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_random
            // 
            this.btn_random.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_random.Location = new System.Drawing.Point(905, 223);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(139, 55);
            this.btn_random.TabIndex = 15;
            this.btn_random.Text = "Random";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // frm_3DESCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 506);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_scananh);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.btn_SavetoFile);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.txt_Ciphertext);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.txt_Plaintext);
            this.Controls.Add(this.lbl_ciphertext);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.lbl_Plaintext);
            this.Controls.Add(this.lbl_3des);
            this.Name = "frm_3DESCipher";
            this.Text = "Mã hoá 3DES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_3des;
        private System.Windows.Forms.Label lbl_Plaintext;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.Label lbl_ciphertext;
        private System.Windows.Forms.TextBox txt_Plaintext;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.TextBox txt_Ciphertext;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Button btn_SavetoFile;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btn_scananh;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_random;
    }
}

