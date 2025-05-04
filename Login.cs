using _3DES.FormThuatToan;
using _3DES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Text.RegularExpressions;

namespace _3DES
{
    public partial class Login : Form
    {
        string username;
        bool tontai = false;
        bool xacthuc = false;
        Random random = new Random();
        int otp;
        DateTime otpGeneratedTime;
        DBContext DBContext = new DBContext();
        public Login()
        {
            InitializeComponent();
            gb_dangki.Visible = false;
            gp_quenmk.Visible = false;
            txt_TaiKhoan.Text = null;
            txt_MatKhau.Text = null;
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            txt_MatKhau.Clear();
            txt_TaiKhoan.Clear();
            gb_dangnhap.Visible = false;
            gb_dangki.Visible  = true;
            gp_quenmk.Visible = false;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TaiKhoan.Text) || string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string inputUsername = txt_TaiKhoan.Text.Trim();

            var user = DBContext.Users.FirstOrDefault(u => u.UserName == inputUsername); 
            if (user != null)
            {
                string ciphertext = user.Passwordct.ToString();
                string secretKey = user.secretKey.ToString();
                string decryptedText = _3DES.Decrypt(ciphertext, secretKey);
                if(txt_MatKhau.Text == decryptedText)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormUser frmuser = new FormUser();
                    frmuser.Show();
                    this.Hide();
                    frmuser.DangXuat += frmUserDangXuat;
                    txt_MatKhau.Clear();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmUserDangXuat(object sender, EventArgs e)
        {
            (sender as FormUser).isThoat = false;
            (sender as FormUser).Close();
            this.Show();
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


        private void btn_dkDangki_Click(object sender, EventArgs e)
        {
            string inputUsername = txt_dktaikhoan.Text.Trim();

            var user = DBContext.Users.FirstOrDefault(u => u.UserName == inputUsername);

            if (string.IsNullOrEmpty(txt_dktaikhoan.Text)|| string.IsNullOrEmpty(txt_dkpassword.Text) || string.IsNullOrEmpty(txt_gmail.Text) || string.IsNullOrEmpty(txt_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đày đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(txt_dktaikhoan.Text.Contains(" ") || txt_dkpassword.Text.Contains(" "))
            {
                MessageBox.Show("Không sử dụng space trong tên tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user != null)
            {
                MessageBox.Show("Đa có tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (xacthuc == false)
            {
                MessageBox.Show("Vui lòng xác thực OTP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string plaintext = txt_dkpassword.Text.Trim();
                string secretKey = GenerateRandomKey();
                string encryptedText = _3DES.Encrypt(plaintext, secretKey);
                User newuser = new User
                {
                    UserName = txt_dktaikhoan.Text.Trim(),
                    HoUser = txt_Ho.Text.Trim(),
                    TenUser = txt_ten.Text.Trim(),
                    Sdt = txt_sdt.Text.Trim(),
                    Gmail = txt_gmail.Text.Trim(),
                    DiaChi = txt_diachi.Text.Trim(),
                    NgaySinh = dtp_ngaysinh.Value,
                    secretKey = secretKey.Trim(),
                    Passwordct = encryptedText.Trim(),
                };
                DBContext.Users.Add(newuser);
                DBContext.SaveChanges();
                MessageBox.Show("Dang ky thanh cong","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt_TaiKhoan.Text = txt_dktaikhoan.Text;
                txt_dktaikhoan.Clear();
                txt_gmail.Clear();
                txt_sdt.Clear();
                txt_diachi.Clear();
                txt_dkpassword.Clear();
                txt_Ho.Clear();
                txt_ten.Clear();
                dtp_ngaysinh.Value = DateTime.Now;
            }
        }

        private void btn_trove_Click(object sender, EventArgs e)
        {
            txt_dktaikhoan.Clear();
            txt_gmail.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
            txt_dkpassword.Clear();
            txt_Ho.Clear();
            txt_ten.Clear();
            gb_dangki.Visible = false;
            gb_dangnhap.Visible = true;
            gp_quenmk.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidEmail(txt_gmail.Text))
                {
                    // Kiểm tra nếu email không hợp lệ
                    MessageBox.Show("Email không hợp lệ");
                    return;
                }

                otp = random.Next(100000, 1000000);

                otpGeneratedTime = DateTime.Now;

                var fromAddress = new MailAddress("ctfcryptotht@gmail.com");
                var toAddress = new MailAddress(txt_gmail.Text);  // Lấy email từ TextBox

                const string fromPass = "gqbt isbw tdck xwoc";
                const string subject = "OTP Code";
                string body = $"Your OTP code is: {otp}";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPass),
                    Timeout = 200000
                };

                using (var message = new MailMessage(fromAddress, toAddress))
                {
                    message.Subject = subject;
                    message.Body = body;
                    smtp.Send(message);
                }

                //MessageBox.Show("OTP đã được gửi qua email.");
                MessageBox.Show("OTP đã được gửi qua email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{3,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void btn_Kiemtra_Click(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now - otpGeneratedTime;

            if (timeElapsed.TotalSeconds > 100)
            {
                MessageBox.Show("OTP đã hết hạn. Vui lòng yêu cầu mã OTP mới.");
                return;
            }

            if (otp.ToString().Equals(txt_otp.Text))
            {
                xacthuc = true;
                MessageBox.Show("Xác minh thành công");
            }
            else
            {
                //MessageBox.Show("OTP không chính xác");
                MessageBox.Show("OTP không chính xác");
            }
        }

        private void gb_dangki_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_quenmk_Click(object sender, EventArgs e)
        {
            tontai = true;
            string inputUsername = txt_TaiKhoan.Text.Trim();
            if (DBContext.Users.FirstOrDefault(u => u.UserName == inputUsername) == null)
            {
                MessageBox.Show("Tên tài khoản không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                gp_quenmk.Visible = true;
                gb_dangki.Visible = false;
                gb_dangnhap.Visible = false;
            }
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            string inputUsername = txt_TaiKhoan.Text.Trim();
            if (xacthuc == false)
            {
                MessageBox.Show("Vui lòng xác thực OTP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_passquen.Text == null )
            {
                MessageBox.Show("Vui long nhap pass");
                return;
            }
            else if (txt_passquen.Text.Contains(" "))
            {
                MessageBox.Show("Password không nhập space");
                return;
            }
            else
            {
                inputUsername = txt_TaiKhoan.Text.Trim();
                var user = DBContext.Users.FirstOrDefault(u => u.UserName == inputUsername);
                if (user != null)
                {
                    string plaintext = txt_passquen.Text.Trim();
                    string secretKey = GenerateRandomKey();
                    string encryptedText = _3DES.Encrypt(plaintext, secretKey);
                    user.Passwordct = encryptedText;
                    user.secretKey = secretKey;
                    DBContext.SaveChanges();
                    MessageBox.Show("Đổi pass thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_MatKhau.Focus();
        }

        private void btn_otpquen_Click(object sender, EventArgs e)
        {
            try
            {
                string inputUsername = txt_TaiKhoan.Text.Trim();
                var user = DBContext.Users.FirstOrDefault(u => u.UserName == inputUsername);
                if (txt_gmailquen.Text != user.Gmail)
                {
                    MessageBox.Show("Gmail không đúng");
                    return;
                }
                if (!IsValidEmail(txt_gmailquen.Text))
                {
                    // Kiểm tra nếu email không hợp lệ
                    MessageBox.Show("Email không hợp lệ");
                    return;
                }

                otp = random.Next(100000, 999999);

                otpGeneratedTime = DateTime.Now;

                var fromAddress = new MailAddress("ctfcryptotht@gmail.com");
                var toAddress = new MailAddress(txt_gmailquen.Text);  // Lấy email từ TextBox

                const string fromPass = "gqbt isbw tdck xwoc";
                const string subject = "OTP Code";
                string body = $"Your OTP code is: {otp}";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPass),
                    Timeout = 200000
                };

                using (var message = new MailMessage(fromAddress, toAddress))
                {
                    message.Subject = subject;
                    message.Body = body;
                    smtp.Send(message);
                }

                //MessageBox.Show("OTP đã được gửi qua email.");
                MessageBox.Show("OTP đã được gửi qua email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btn_kiemtraquen_Click(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now - otpGeneratedTime;

            if (timeElapsed.TotalSeconds > 100)
            {
                MessageBox.Show("OTP đã hết hạn. Vui lòng yêu cầu mã OTP mới.");
                return;
            }

            if (otp.ToString().Equals(txt_otpquen.Text))
            {
                xacthuc = true;
                MessageBox.Show("Xác minh thành công");
            }
            else
            {
                //MessageBox.Show("OTP không chính xác");
                MessageBox.Show("OTP không chính xác");
            }
        }

        private void btn_doimk_MouseHover(object sender, EventArgs e)
        {
            btn_doimk.Cursor = Cursors.Hand;
            btn_trovedn.Cursor = Cursors.Hand;
            btn_otpquen.Cursor = Cursors.Hand;
            btn_kiemtraquen.Cursor = Cursors.Hand;
            btn_guiotp.Cursor = Cursors.Hand;
            btn_Kiemtra.Cursor = Cursors.Hand;
            btn_dkDangki.Cursor = Cursors.Hand;
            btn_trove.Cursor = Cursors.Hand;
            btn_dangky.Cursor = Cursors.Hand;
            btn_dangnhap.Cursor = Cursors.Hand;
            lbl_quenmk.Cursor = Cursors.Hand;
            lblEyeView.Cursor = Cursors.Hand;
            lblEyeDK.Cursor = Cursors.Hand;
        }

        private void lblEyeView_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.PasswordChar == '*')
            {
                txt_MatKhau.PasswordChar = '\0';  // '\0' là ký tự null, không thay thế bằng gì
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }

        private void lblEyeDK_Click(object sender, EventArgs e)
        {
            if (txt_dkpassword.PasswordChar == '*')
            {
                txt_dkpassword.PasswordChar = '\0';  // '\0' là ký tự null, không thay thế bằng gì
            }
            else
            {
                txt_dkpassword.PasswordChar = '*';
            }
        }
    }
}
