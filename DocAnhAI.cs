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
using System.Xml.Linq;
using Tesseract;
using System.Speech.Synthesis;
using System.Security.Cryptography;
using _3DES.CodeMaHoa;
using System.Numerics;

namespace _3DES
{
    public partial class DocAnhAI : Form
    {
        public string Scananh { get; set; }
        private Image originalImage;
        private float currentAngle = 0;
        public bool isThoat = true;
        private RSACipher rsa = new RSACipher(1024);
        private BigInteger n;
        private BigInteger d;
        public DocAnhAI()
        {
            InitializeComponent();
            txtText.ReadOnly = true;
            pbxImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImg.AllowDrop = true;
        }
     
        private void pbxImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Chọn hình ảnh"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxImg.Image = Image.FromFile(ofd.FileName);
                originalImage = pbxImg.Image;
            }
        }

        private void pbxImg_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && (files[0].EndsWith(".jpg") || files[0].EndsWith(".jpeg") || files[0].EndsWith(".png") || files[0].EndsWith(".bmp")))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pbxImg_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && File.Exists(files[0]) &&
                (files[0].EndsWith(".jpg") || files[0].EndsWith(".jpeg") || files[0].EndsWith(".png") || files[0].EndsWith(".bmp")))
            {
                pbxImg.Image = Image.FromFile(files[0]);
                originalImage = pbxImg.Image;
            }
            else
            {
                MessageBox.Show("File không hợp lệ. Vui lòng chọn file hình ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnResult_Click(object sender, EventArgs e)
        {
            if (pbxImg.Image == null)
            {
                MessageBox.Show("Vui lòng thêm hình ảnh trước khi xử lý!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnResult.Enabled = false; // Vô hiệu hóa nút khi đang xử lý
                txtText.Text = "Đang xử lý OCR...";

                string tempPath = Path.GetTempFileName();
                pbxImg.Image.Save(tempPath);
                string resultText = await Task.Run(() =>
                {
                    using (var ocrEngine = new TesseractEngine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata"), "vie+eng", EngineMode.Default))
                    {
                        var img = Pix.LoadFromFile(tempPath);
                        return ocrEngine.Process(img).GetText();
                    }
                });

                txtText.Text = resultText;

                // Giải phóng hình ảnh và file tạm
                //pbxImg.Image.Dispose();
                //pbxImg.Image = null;
                File.Delete(tempPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xử lý OCR: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnResult.Enabled = true; // Bật lại nút
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                if (Clipboard.ContainsImage())
                {
                    pbxImg.Image = Clipboard.GetImage();
                    originalImage = pbxImg.Image;
                }
                else
                {
                    MessageBox.Show("Dữ liệu trong clipboard không phải hình ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnResult_MouseHover(object sender, EventArgs e)
        {
            pbxImg.Cursor = Cursors.Hand;
            btnResult.Cursor = Cursors.Hand;
            btnXoaHinh.Cursor = Cursors.Hand;
            btnXoaText.Cursor = Cursors.Hand;
            btnL.Cursor = Cursors.Hand;
            btnR.Cursor = Cursors.Hand;
        }

        private void btnXoaHinh_Click(object sender, EventArgs e)
        {
            if (pbxImg.Image != null)
            {
                pbxImg.Image.Dispose();
                pbxImg.Image = null;
                MessageBox.Show("Hình ảnh đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có hình ảnh nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaText_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtText.Text))
            {
                txtText.Text = string.Empty;
                MessageBox.Show("Văn bản đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có văn bản nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtText.Text))
            {
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Volume = 100; // Âm lượng (0-100)
                synthesizer.Rate = 0;     // Tốc độ nói (-10 đến 10)
                synthesizer.SpeakAsync(txtText.Text); // Đọc văn bản
            }
            else
            {
                MessageBox.Show("Không có văn bản nào để đọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Image RotateImage(Image img, float angle)
        {
            Bitmap rotatedBmp = new Bitmap(img);
            rotatedBmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                g.Clear(Color.Transparent);
                g.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);

                g.DrawImage(img, new Point(0, 0));
            }

            return rotatedBmp;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                currentAngle += 90;
                pbxImg.Image = RotateImage(originalImage, currentAngle);
            }
            else
            {
                MessageBox.Show("Vui lòng dán một hình ảnh vào PictureBox trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnL_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                currentAngle -= 90;
                pbxImg.Image = RotateImage(originalImage, currentAngle);
            }
            else
            {
                MessageBox.Show("Vui lòng dán một hình ảnh vào PictureBox trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_en_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtText.Text))
            {
                MessageBox.Show("Vui lòng scan ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Scananh == "3DES")
                {
                    if (string.IsNullOrWhiteSpace(txt_Key.Text))
                    {
                        MessageBox.Show("Vui lòng nhap key", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txt_Key.Text.Length < 24)
                    {
                        MessageBox.Show("Vui lòng nhập >= 24 kí tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string plaintext = txtText.Text;
                    string secretKey = txt_Key.Text;
                    string encryptedText = _3DES.Encrypt(plaintext, secretKey);
                    txt_Ciphertext.Text = encryptedText;
                }
                if (Scananh == "RSA")
                {
                    string plaintext = txtText.Text;
                    n = rsa.GetN();
                    d = rsa.GetD();

                    BigInteger[] ciphertext = rsa.Encrypt(plaintext);
                    StringBuilder sb = new StringBuilder();
                    foreach (BigInteger ct in ciphertext)
                    {
                        sb.Append(ct.ToString("X")).Append(" ");
                    }
                    txt_Ciphertext.Text = sb.ToString().Trim();
                }
                if (Scananh == "RC4")
                {
                    if (string.IsNullOrWhiteSpace(txt_Key.Text))
                    {
                        MessageBox.Show("Vui lòng nhap key", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string plaintext = txtText.Text;
                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
                    string key = txt_Key.Text;
                    RC4Cipher rc4 = new RC4Cipher(Encoding.UTF8.GetBytes(key));
                    byte[] ciphertextBytes = rc4.Encrypt(plaintextBytes);
                    string ciphertext = BytesToHexString(ciphertextBytes);
                    txt_Ciphertext.Text = ciphertext;
                }
            }
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

        private void DocAnhAI_Load(object sender, EventArgs e)
        {
            if(Scananh == "RSA")
            {
                lbl_key.Enabled = false;
                txt_Key.Enabled = false;
            }
            if (Scananh == "3DES")
            {
                btn_random.Visible = true;
            }
            if (Scananh != null)
            {
                btn_en.Enabled = true;
            }
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            string plaintext = txtText.Text;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save Ciphertext to File";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, plaintext);
                        MessageBox.Show("Ciphertext saved to file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public event EventHandler thoat;
       

        private void btn_trove_Click(object sender, EventArgs e)
        {
            if(Scananh != null)
            {
                thoat(this, new EventArgs());
            }
            else
            {
                thoat(this, new EventArgs());
            }
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
