using _3DES.CodeMaHoa;
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
    public partial class frm_RC4 : Form
    {
        public string scananh;
        public bool isThoat = true;
        public frm_RC4()
        {
            InitializeComponent();
        }
        private RC4Cipher rc4;

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlain.Text) || string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string plaintext = txtPlain.Text;
            byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
            string key = txtKey.Text;
            rc4 = new RC4Cipher(Encoding.UTF8.GetBytes(key));
            byte[] ciphertextBytes = rc4.Encrypt(plaintextBytes);
            string ciphertext = BytesToHexString(ciphertextBytes);
            txtCipher.Text = ciphertext;
        }

        private string BytesToHexString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.AppendFormat("{0:X2}", b);
            }
            return sb.ToString();
        }

        private byte[] HexStringToByteArray(string s)
        {
            int len = s.Length;
            byte[] data = new byte[len / 2];
            for (int i = 0; i < len; i += 2)
            {
                data[i / 2] = (byte)((Convert.ToInt32(s[i].ToString(), 16) << 4) + Convert.ToInt32(s[i + 1].ToString(), 16));
            }
            return data;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCipher.Text) || string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ciphertext = txtCipher.Text;
            byte[] ciphertextBytes = HexStringToByteArray(ciphertext);
            string key = txtKey.Text;
            rc4 = new RC4Cipher(Encoding.UTF8.GetBytes(key));
            byte[] decryptedBytes = rc4.Decrypt(ciphertextBytes);
            string decryptext = Encoding.UTF8.GetString(decryptedBytes);
            txtPlain.Text = decryptext;
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            string ciphertext = txtCipher.Text;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save Ciphertext to File";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, ciphertext);
                        MessageBox.Show("Ciphertext saved to file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open File Containing Ciphertext";
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string ciphertext = File.ReadAllText(openFileDialog.FileName).Trim();
                        txtCipher.Text = ciphertext;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error opening file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_scananh_Click(object sender, EventArgs e)
        {
            scananh = "RC4";
            DocAnhAI docAnhAI = new DocAnhAI();
            docAnhAI.Scananh = scananh;
            docAnhAI.Show();
            this.Hide();
            docAnhAI.thoat += frmdocanhRC4;
        }
        private void frmdocanhRC4(object sender, EventArgs e)
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
    }
}
