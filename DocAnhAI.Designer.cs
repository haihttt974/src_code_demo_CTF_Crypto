namespace _3DES
{
    partial class DocAnhAI
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
            this.btnResult = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            this.btnXoaText = new System.Windows.Forms.Button();
            this.btnXoaHinh = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.txt_Key = new System.Windows.Forms.RichTextBox();
            this.txt_Ciphertext = new System.Windows.Forms.RichTextBox();
            this.btn_en = new System.Windows.Forms.Button();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.lbl_plaintext = new System.Windows.Forms.Label();
            this.lbl_key = new System.Windows.Forms.Label();
            this.lbl_Ciphertext = new System.Windows.Forms.Label();
            this.btn_trove = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(773, 637);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(141, 52);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            this.btnResult.MouseHover += new System.EventHandler(this.btnResult_MouseHover);
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtText.Location = new System.Drawing.Point(773, 40);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(689, 258);
            this.txtText.TabIndex = 2;
            this.txtText.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbxImg);
            this.groupBox1.Location = new System.Drawing.Point(2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 627);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pbxImg
            // 
            this.pbxImg.Location = new System.Drawing.Point(6, 14);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(678, 607);
            this.pbxImg.TabIndex = 0;
            this.pbxImg.TabStop = false;
            this.pbxImg.Click += new System.EventHandler(this.pbxImg_Click);
            this.pbxImg.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxImg_DragDrop);
            this.pbxImg.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxImg_DragEnter);
            this.pbxImg.MouseHover += new System.EventHandler(this.btnResult_MouseHover);
            // 
            // btnXoaText
            // 
            this.btnXoaText.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaText.Location = new System.Drawing.Point(344, 638);
            this.btnXoaText.Name = "btnXoaText";
            this.btnXoaText.Size = new System.Drawing.Size(347, 51);
            this.btnXoaText.TabIndex = 4;
            this.btnXoaText.Text = "Xóa văn bản";
            this.btnXoaText.UseVisualStyleBackColor = true;
            this.btnXoaText.Click += new System.EventHandler(this.btnXoaText_Click);
            this.btnXoaText.MouseHover += new System.EventHandler(this.btnResult_MouseHover);
            // 
            // btnXoaHinh
            // 
            this.btnXoaHinh.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold);
            this.btnXoaHinh.Location = new System.Drawing.Point(8, 638);
            this.btnXoaHinh.Name = "btnXoaHinh";
            this.btnXoaHinh.Size = new System.Drawing.Size(330, 51);
            this.btnXoaHinh.TabIndex = 5;
            this.btnXoaHinh.Text = "Xóa hình";
            this.btnXoaHinh.UseVisualStyleBackColor = true;
            this.btnXoaHinh.Click += new System.EventHandler(this.btnXoaHinh_Click);
            this.btnXoaHinh.MouseHover += new System.EventHandler(this.btnResult_MouseHover);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeak.Location = new System.Drawing.Point(692, 26);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 51);
            this.btnSpeak.TabIndex = 6;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnR
            // 
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(697, 237);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(70, 61);
            this.btnR.TabIndex = 7;
            this.btnR.Text = "^";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            this.btnR.MouseHover += new System.EventHandler(this.btnResult_MouseHover);
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnL.Location = new System.Drawing.Point(697, 345);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(70, 74);
            this.btnL.TabIndex = 7;
            this.btnL.Text = "v";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            this.btnL.MouseHover += new System.EventHandler(this.btnResult_MouseHover);
            // 
            // txt_Key
            // 
            this.txt_Key.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Key.Location = new System.Drawing.Point(773, 335);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(689, 69);
            this.txt_Key.TabIndex = 8;
            this.txt_Key.Text = "";
            // 
            // txt_Ciphertext
            // 
            this.txt_Ciphertext.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Ciphertext.Location = new System.Drawing.Point(773, 448);
            this.txt_Ciphertext.Name = "txt_Ciphertext";
            this.txt_Ciphertext.Size = new System.Drawing.Size(689, 159);
            this.txt_Ciphertext.TabIndex = 9;
            this.txt_Ciphertext.Text = "";
            // 
            // btn_en
            // 
            this.btn_en.Enabled = false;
            this.btn_en.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_en.Location = new System.Drawing.Point(939, 638);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(159, 51);
            this.btn_en.TabIndex = 11;
            this.btn_en.Text = "Encrypt";
            this.btn_en.UseVisualStyleBackColor = true;
            this.btn_en.Click += new System.EventHandler(this.btn_en_Click);
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveFile.Location = new System.Drawing.Point(1119, 638);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(167, 52);
            this.btn_SaveFile.TabIndex = 13;
            this.btn_SaveFile.Text = "Save file plaintext";
            this.btn_SaveFile.UseVisualStyleBackColor = true;
            this.btn_SaveFile.Click += new System.EventHandler(this.btn_SaveFile_Click);
            // 
            // lbl_plaintext
            // 
            this.lbl_plaintext.AutoSize = true;
            this.lbl_plaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plaintext.Location = new System.Drawing.Point(773, 9);
            this.lbl_plaintext.Name = "lbl_plaintext";
            this.lbl_plaintext.Size = new System.Drawing.Size(86, 25);
            this.lbl_plaintext.TabIndex = 14;
            this.lbl_plaintext.Text = "Plaintext";
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_key.Location = new System.Drawing.Point(773, 301);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(47, 25);
            this.lbl_key.TabIndex = 15;
            this.lbl_key.Text = "Key";
            // 
            // lbl_Ciphertext
            // 
            this.lbl_Ciphertext.AutoSize = true;
            this.lbl_Ciphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ciphertext.Location = new System.Drawing.Point(773, 407);
            this.lbl_Ciphertext.Name = "lbl_Ciphertext";
            this.lbl_Ciphertext.Size = new System.Drawing.Size(101, 25);
            this.lbl_Ciphertext.TabIndex = 16;
            this.lbl_Ciphertext.Text = "Ciphertext";
            // 
            // btn_trove
            // 
            this.btn_trove.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trove.Location = new System.Drawing.Point(1295, 637);
            this.btn_trove.Name = "btn_trove";
            this.btn_trove.Size = new System.Drawing.Size(167, 52);
            this.btn_trove.TabIndex = 13;
            this.btn_trove.Text = "Trở về";
            this.btn_trove.UseVisualStyleBackColor = true;
            this.btn_trove.Click += new System.EventHandler(this.btn_trove_Click);
            // 
            // btn_random
            // 
            this.btn_random.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_random.Location = new System.Drawing.Point(1336, 406);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(126, 35);
            this.btn_random.TabIndex = 17;
            this.btn_random.Text = "Random key";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Visible = false;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // DocAnhAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 708);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.lbl_Ciphertext);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.lbl_plaintext);
            this.Controls.Add(this.btn_trove);
            this.Controls.Add(this.btn_SaveFile);
            this.Controls.Add(this.btn_en);
            this.Controls.Add(this.txt_Ciphertext);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btnXoaHinh);
            this.Controls.Add(this.btnXoaText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnResult);
            this.Name = "DocAnhAI";
            this.Text = "frm_AI";
            this.Load += new System.EventHandler(this.DocAnhAI_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImg;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaText;
        private System.Windows.Forms.Button btnXoaHinh;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.RichTextBox txt_Key;
        private System.Windows.Forms.RichTextBox txt_Ciphertext;
        private System.Windows.Forms.Button btn_en;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.Label lbl_plaintext;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.Label lbl_Ciphertext;
        private System.Windows.Forms.Button btn_trove;
        private System.Windows.Forms.Button btn_random;
    }
}