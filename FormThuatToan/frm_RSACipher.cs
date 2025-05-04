using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3DES.CodeMaHoa;

namespace _3DES.FormThuatToan
{
    public partial class frm_RSACipher : Form
    {
        public string scananh;
        public bool isThoat = true;
        private RSACipher rsa = new RSACipher(1024);
        private BigInteger n;
        private BigInteger d;

        public frm_RSACipher()
        {
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            string plaintext = txt_plaintext.Text;
            n = rsa.GetN();
            d = rsa.GetD();

            BigInteger[] ciphertext = rsa.Encrypt(plaintext);
            StringBuilder sb = new StringBuilder();
            foreach (BigInteger ct in ciphertext)
            {
                sb.Append(ct.ToString("X")).Append(" ");
            }
            txt_ciphertext.Text = sb.ToString().Trim();

        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            string[] ctStrings = txt_ciphertext.Text.Split(' ');
            BigInteger[] ciphertext = new BigInteger[ctStrings.Length];
            for (int i = 0; i < ctStrings.Length; i++)
            {
                ciphertext[i] = BigInteger.Parse(ctStrings[i], System.Globalization.NumberStyles.HexNumber);
            }
            string plaintext = rsa.Decrypt(ciphertext, d, n);
            txt_plaintext.Text = plaintext;
        }

        private void frm_RSACipher_Load(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }
        public event EventHandler DangXuat;

        private void btn_scananh_Click(object sender, EventArgs e)
        {
            scananh = "RSA";
            DocAnhAI docAnhAI = new DocAnhAI();
            docAnhAI.Scananh = scananh;
            docAnhAI.Show();
            this.Hide();
            docAnhAI.thoat += frmdocanhRSA;

        }
        private void frmdocanhRSA(object sender, EventArgs e)
        {
            (sender as DocAnhAI).isThoat = false;
            (sender as DocAnhAI).Close();
            this.Show();
        }
    }
}
