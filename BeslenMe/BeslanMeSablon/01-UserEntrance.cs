using Dal;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeslanMeSablon
{
    public partial class UserEntrance : Form
    {
        public UserEntrance()
        {
            InitializeComponent();
        }
        public static string getUserMail;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            db = new BeslenMeContext();
            var kullaniciAdi = db.Users.Where(x => x.User_E_Mail == (txtUserName.Text)).FirstOrDefault();
            var kullaniciSifre = db.Users.Where(x => x.User_password == (txtUserPassword.Text)).FirstOrDefault();

            db.SaveChanges();

            if (kullaniciAdi != null && kullaniciSifre != null)
            {
                if (kullaniciAdi.User_E_Mail == txtUserName.Text && kullaniciSifre.User_password == txtUserPassword.Text)
                {
                    getUserMail = kullaniciAdi.User_E_Mail;
                    Main main = new Main(this);
                    main.Show();
                    this.Hide();

                }
                else if (kullaniciAdi.User_E_Mail != txtUserName.Text || kullaniciSifre.User_password != txtUserPassword.Text)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                    txtUserName.Text = string.Empty;
                    txtUserPassword.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılmamalı!");
                txtUserName.Text = string.Empty;
                txtUserPassword.Text = string.Empty;
            }
        }
        BeslenMeContext db = new BeslenMeContext();
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Introduction intro = new Introduction();
            intro.Show();
            this.Hide();
        }
        private void chkShowOrHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowOrHidePassword.Checked == false)
            {
                txtUserPassword.PasswordChar = '*';
            }
            else
            {
                txtUserPassword.PasswordChar = default;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UserEntrance_Load(object sender, EventArgs e)
        {
            txtUserPassword.PasswordChar = '*';
            chkShowOrHidePassword.Checked = false;
        }
    }
}
