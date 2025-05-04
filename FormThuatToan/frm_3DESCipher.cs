using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DES.FormThuatToan
{
    public partial class frm_3DESCipher : Form
    {
        public string scananh;
        public bool isThoat = true;
        public frm_3DESCipher()
        {
            InitializeComponent();
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string plaintext = txt_Plaintext.Text;
                string secretKey = txt_Key.Text;
                if (secretKey.Length >= 24)
                {
                    string encryptedText = _3DES.Encrypt(plaintext, secretKey);
                    txt_Ciphertext.Text = encryptedText;
                }else if (string.IsNullOrEmpty(txt_Plaintext.Text))
                {
                    MessageBox.Show("Vui lòng nhập Plaintext","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập >= 24 kí tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string ciphertext = txt_Ciphertext.Text;
                string secretKey = txt_Key.Text;

                //Uncomment this block if you want to validate the key length
                if (secretKey.Length >= 24)
                {
                    string decryptedText = _3DES.Decrypt(ciphertext, secretKey);
                    txt_Plaintext.Text = decryptedText;
                }
                else if (string.IsNullOrEmpty(txt_Ciphertext.Text))
                {
                    MessageBox.Show("Vui lòng nhập Ciphertext", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập >= 24 kí tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open File containing ciphertext and key";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        string fileContent = File.ReadAllText(filePath);

                        // Tách dữ liệu dựa trên dấu phân cách
                        string[] parts = fileContent.Split(new string[] { "\n---KEY---\n" }, StringSplitOptions.None);

                        if (parts.Length == 2)
                        {
                            txt_Ciphertext.Text = parts[0].Trim();
                            txt_Key.Text = parts[1].Trim();
                        }
                        else
                        {
                            MessageBox.Show("File format is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error opening file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_SavetoFile_Click(object sender, EventArgs e)
        {
            string ciphertext = txt_Ciphertext.Text;
            string key = txt_Key.Text;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save Ciphertext and Key to File";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = saveFileDialog.FileName;
                        // Lưu cả ciphertext và key vào file, ngăn cách bằng ký tự đặc biệt
                        File.WriteAllText(filePath, $"{ciphertext}\n---KEY---\n{key}");
                        MessageBox.Show("Ciphertext and key saved to file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_scananh_Click(object sender, EventArgs e)
        {
            scananh = "3DES";
            DocAnhAI docAnhAI = new DocAnhAI();
            docAnhAI.Scananh = scananh;
            docAnhAI.Show();
            this.Hide();
            docAnhAI.thoat += frmdocanhDES;
        }
        private void frmdocanhDES(object sender, EventArgs e)
        {
            (sender as DocAnhAI).isThoat = false;
            (sender as DocAnhAI).Close();
            this.Show();
        }
        public event EventHandler DangXuat;
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private string GenerateRandomKey()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random keyrandom = new Random();

            // Random độ dài secretKey từ 24 đến 36
            int length = keyrandom.Next(24, 37);

            return new string(Enumerable.Repeat(chars, length)
                                        .Select(s => s[keyrandom.Next(s.Length)]).ToArray());
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            txt_Key.Text = GenerateRandomKey();
        }
    }
}
