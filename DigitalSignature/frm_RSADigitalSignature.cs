using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DES.DigitalSignature
{
    public partial class frm_RSADigitalSignature : Form
    {
        private RSADigitalSignarute rsaDigitalSignature = new RSADigitalSignarute();
        private string privateKey;
        private string publicKey;
        private string loadedPublicKey;
        public bool isThoat = true;
        public frm_RSADigitalSignature()
        {
            InitializeComponent();
            GenerateKeys();
        }
        private void GenerateKeys()
        {
            rsaDigitalSignature.GenerateKeyPair(out publicKey, out privateKey);
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn tệp để ký",
                Filter = "All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = openFileDialog.FileName;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputFile.Text))
            {
                MessageBox.Show("Vui lòng chọn tệp để ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Lưu chữ ký",
                Filter = "XML Files (*.xml)|*.xml",
                FileName = "signature.xml"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string signatureBase64 = rsaDigitalSignature.SignFile(txtInputFile.Text, privateKey);
                rsaDigitalSignature.SaveSignatureToXml(signatureBase64, saveFileDialog.FileName);
                MessageBox.Show("Chữ ký đã được tạo và lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSavePublickey_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Lưu Public Key",
                Filter = "XML Files (*.xml)|*.xml",
                FileName = "publickey.xml"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                rsaDigitalSignature.SavePublicKeyToXml(publicKey, saveFileDialog.FileName);
                MessageBox.Show("Public Key đã được lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOpenFileVerify_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn tệp cần xác thực",
                Filter = "All Files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInputFileVerify.Text = openFileDialog.FileName;
            }
        }

        private void btnChooseSignature_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn tệp chữ ký",
                Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSignatureFile.Text = openFileDialog.FileName;
            }
        }
        private string FormatPublicKey(string rawKeyContent)
        {
            // Kiểm tra và đảm bảo nội dung nằm trong đúng thẻ XML
            if (!rawKeyContent.TrimStart().StartsWith("<"))
            {
                rawKeyContent = $"<RSAKeyValue>{rawKeyContent}</RSAKeyValue>";
            }

            // Loại bỏ ký tự không hợp lệ hoặc xuống dòng dư thừa
            rawKeyContent = rawKeyContent.Replace("\r", "").Replace("\n", "").Trim();

            return rawKeyContent;
        }

        private void btnChoosePublickey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn tệp Public Key",
                Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPublicKey.Text = openFileDialog.FileName;
            }
        }

        private void btnCheckSignature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputFileVerify.Text) ||
                string.IsNullOrEmpty(txtSignatureFile.Text) ||
                string.IsNullOrEmpty(txtPublicKey.Text))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ tệp cần xác thực, chữ ký và public key!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kiểm tra tệp tồn tại
                if (!File.Exists(txtInputFileVerify.Text))
                    throw new FileNotFoundException($"Không tìm thấy tệp: {txtInputFileVerify.Text}");

                if (!File.Exists(txtSignatureFile.Text))
                    throw new FileNotFoundException($"Không tìm thấy tệp chữ ký: {txtSignatureFile.Text}");

                if (!File.Exists(txtPublicKey.Text))
                    throw new FileNotFoundException($"Không tìm thấy tệp Public Key: {txtPublicKey.Text}");

                // Đọc tệp chữ ký (Base64)
                string signatureBase64 = rsaDigitalSignature.LoadKeyFromFile(txtSignatureFile.Text)
                    .Replace("<Signature>", "").Replace("</Signature>", "").Trim();

                // Đọc Public Key
                string publicKeyXml = rsaDigitalSignature.LoadKeyFromFile(txtPublicKey.Text);

                // Xác minh chữ ký
                bool isValid = rsaDigitalSignature.VerifyFileSignature(txtInputFileVerify.Text, signatureBase64, publicKeyXml);

                MessageBox.Show(isValid ? "Chữ ký hợp lệ!" : "Chữ ký không hợp lệ!", "Kết quả", MessageBoxButtons.OK, isValid ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            RSADigitalSignarute rsaDigitalSignature = new RSADigitalSignarute();
            string publicKey, privateKey;

            // Tạo cặp khóa
            rsaDigitalSignature.GenerateKeyPair(out publicKey, out privateKey);

            // Hiển thị Public Key trên txtPublicKey
            txtPublickeyInput.Text = publicKey;

            // Lưu Private Key vào file (nếu cần)
            rsaDigitalSignature.SaveKeyToFile(privateKey, "privateKey.txt");

            MessageBox.Show("Cặp khóa đã được tạo thành công và Public Key đã hiển thị!");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem các đường dẫn và email đã được nhập chưa
                if (string.IsNullOrWhiteSpace(txt_Email.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn đủ file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng MailMessage
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("ctfcryptotht@gmail.com"), // Địa chỉ email gửi
                    Subject = "Đính kèm các file từ WinForms",
                    Body = "Đây là các file được đính kèm từ ứng dụng WinForms.",
                    IsBodyHtml = false // Nội dung email là plain text
                };
                
                // Thêm người nhận
                mail.To.Add(txt_Email.Text);
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Chọn để gửi email",
                    Filter = "All Files (*.*)|*.*",
                    Multiselect = true
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] fileNames = openFileDialog.FileNames;

                    // Kiểm tra nếu người dùng chọn ít nhất 3 file
                    if (fileNames.Length < 3)
                    {
                        MessageBox.Show("Vui lòng chọn ít nhất 3 file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Đính kèm các file vào email
                    for (int i = 0; i < 3; i++)
                    {
                        mail.Attachments.Add(new Attachment(fileNames[i]));
                    }

                    // Cấu hình SMTP
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587) // Sử dụng SMTP của Gmail
                    {
                        Credentials = new NetworkCredential("ctfcryptotht@gmail.com", "gqbt isbw tdck xwoc"), // Đăng nhập email
                        EnableSsl = true // Bật SSL để bảo mật
                    };

                    // Gửi email
                    smtp.Send(mail);
                    MessageBox.Show("Gửi email thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có file nào được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public event EventHandler DangXuat;
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }
    }
}
