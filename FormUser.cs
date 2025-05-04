using _3DES.DigitalSignature;
using _3DES.FormThuatToan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
namespace _3DES
{
    public partial class FormUser : Form
    {
        public bool isThoat = true;
        public FormUser()
        {
            InitializeComponent();
        }

        private void dESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_3DESCipher uc3DES = new frm_3DESCipher();
            uc3DES.Show();
            this.Hide();
            uc3DES.DangXuat += frm3DES;
        }

        private void frm3DES(object sender, EventArgs e)
        {
            (sender as frm_3DESCipher).isThoat = false;
            (sender as frm_3DESCipher).Close();
            this.Show();
        }

        private void aESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RSACipher frm_RSACipher = new frm_RSACipher();
            frm_RSACipher.Show();
            this.Hide();
            frm_RSACipher.DangXuat += frmRSA;
        }

        private void frmRSA(object sender, EventArgs e)
        {
            (sender as frm_RSACipher).isThoat = false;
            (sender as frm_RSACipher).Close();
            this.Show();
        }

        private void rC4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RC4 frm_RC4 = new frm_RC4();    
            frm_RC4.Show();
            this.Hide();
            frm_RC4.DangXuat += frmRC4;
        }
        private void frmRC4(object sender, EventArgs e)
        {
            (sender as frm_RC4).isThoat = false;
            (sender as frm_RC4).Close();
            this.Show();
        }
        private void chữKýSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RSADigitalSignature chuky = new frm_RSADigitalSignature();
            chuky.Show();
            this.Hide();
            chuky.DangXuat += frmchuky;
        }
        private void frmchuky(object sender, EventArgs e)
        {
            (sender as frm_RSADigitalSignature).isThoat = false;
            (sender as frm_RSADigitalSignature).Close();
            this.Show();
        }

        private void scanẢnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocAnhAI docAnhAI = new DocAnhAI();
            docAnhAI.Show();
            this.Hide();
            docAnhAI.thoat += frmDocAnhThoat;
        }

        private void frmDocAnhThoat(object sender, EventArgs e)
        {
            (sender as DocAnhAI).isThoat = false;
            (sender as DocAnhAI).Close();
            this.Show();
        }
        public event EventHandler DangXuat;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                DangXuat(this, new EventArgs());
            }
        }

        private void FormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }
    }
}
