namespace _3DES.FormThuatToan
{
    partial class frm_RSACipher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_plaintext = new System.Windows.Forms.RichTextBox();
            this.txt_ciphertext = new System.Windows.Forms.RichTextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_scananh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSA Cipher Demo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Plaintext";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ciphertext";
            // 
            // txt_plaintext
            // 
            this.txt_plaintext.Location = new System.Drawing.Point(149, 84);
            this.txt_plaintext.Name = "txt_plaintext";
            this.txt_plaintext.Size = new System.Drawing.Size(650, 95);
            this.txt_plaintext.TabIndex = 1;
            this.txt_plaintext.Text = "";
            // 
            // txt_ciphertext
            // 
            this.txt_ciphertext.Location = new System.Drawing.Point(149, 198);
            this.txt_ciphertext.Name = "txt_ciphertext";
            this.txt_ciphertext.Size = new System.Drawing.Size(650, 89);
            this.txt_ciphertext.TabIndex = 1;
            this.txt_ciphertext.Text = "";
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_encrypt.Location = new System.Drawing.Point(248, 307);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(147, 45);
            this.btn_encrypt.TabIndex = 2;
            this.btn_encrypt.Text = "ENCRYPT";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_decrypt.Location = new System.Drawing.Point(523, 307);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(140, 45);
            this.btn_decrypt.TabIndex = 2;
            this.btn_decrypt.Text = "DECRYPT";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_thoat.Location = new System.Drawing.Point(805, 307);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(138, 45);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_scananh
            // 
            this.btn_scananh.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_scananh.Location = new System.Drawing.Point(805, 84);
            this.btn_scananh.Name = "btn_scananh";
            this.btn_scananh.Size = new System.Drawing.Size(138, 95);
            this.btn_scananh.TabIndex = 13;
            this.btn_scananh.Text = "Scan plaintext";
            this.btn_scananh.UseVisualStyleBackColor = true;
            this.btn_scananh.Click += new System.EventHandler(this.btn_scananh_Click);
            // 
            // frm_RSACipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 383);
            this.Controls.Add(this.btn_scananh);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.txt_ciphertext);
            this.Controls.Add(this.txt_plaintext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_RSACipher";
            this.Text = "frm_RSACipher";
            this.Load += new System.EventHandler(this.frm_RSACipher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_plaintext;
        private System.Windows.Forms.RichTextBox txt_ciphertext;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_scananh;
    }
}