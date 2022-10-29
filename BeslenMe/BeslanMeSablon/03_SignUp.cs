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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        BeslenMeContext db = new BeslenMeContext();
        private void btnContinueToMain_Click(object sender, EventArgs e)
        {
            UserEntrance userEntrance = new UserEntrance();

            User user = new User();

            int counter = 0;
            Regex pass = new Regex(@"^[^şçğüöıŞÇĞÜÖİ]{6,12}$");
            string password = txtUserPassword.Text;
            Regex sLetter = new Regex(@"[a-z]");
            Regex cLetter = new Regex(@"[A-Z]");
            Regex number = new Regex(@"[0-9]");
            Regex signs = new Regex(@"[\.]|[\?]|[\\]|[\*]|[\;]|[\,]|[\:]|[-_!']");

            if (pass.IsMatch(password) && txtUserMail.Text.Contains("@") && txtUserMail.Text.Contains(".com"))
            {
                if (sLetter.IsMatch(password)) { counter++; }
                if (cLetter.IsMatch(password)) { counter++; }
                if (number.IsMatch(password)) { counter++; }
                if (signs.IsMatch(password)) { counter++; }
                if (counter >= 3)
                {
                    user.User_password = txtUserPassword.Text;
                    user.User_E_Mail = txtUserMail.Text.ToString();
                    user.Height = (int)nmrHeight.Value;
                    user.Weight = (int)nmrWeight.Value;
                    user.BirhtDate = dtBirthDate.Value;
                    user.Gender = rbMale.Checked ? true : false;

                    if (user.Gender == true) //Erkek
                    {
                        double maleBasalMetabolismRatio = 66.5 + (13.75 * user.Weight) + (5.03 * Height) - (6.75 * user.Age);
                        user.BasalMetabolism = maleBasalMetabolismRatio;
                    }
                    else // Kadın
                    {
                        double femaleBasalMetabolismRatio = 655.1 + (9.56 * user.Weight) + (1.85 * Height) - (4.68 * user.Age);
                        user.BasalMetabolism = femaleBasalMetabolismRatio;
                    }
                    user.OptimalCal = user.BasalMetabolism * 1.35;

                    user.Age = Methods.getAge(dtBirthDate.Value);

                    db.Users.Add(user);
                    MessageBox.Show("Kayıt Başarılı!");
                    db.SaveChanges();
                    userEntrance.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Daha güçlü parola girin!");
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("E-mail veya şifre bilgileriniz doğru formatta değil");
            }
            if (rbFemale.Checked == false && rbMale.Checked == false)
            {
                MessageBox.Show("Cinsiyet seçimi yapmadınız. Lütfen cinsiyet seçiniz.");
                btnContinueToMain.Visible = false;
            }
            else
            {
                btnContinueToMain.Visible = true;
            }

        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            lblContains.Visible = false;
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
            lblContains.Visible = true;
            lblContains.Text = "Şifreniz türkçe karkter içermeyen içinde en az bir büyük bir en az \n küçük en az bir özel ve en az bir sayı içeren 6 ila 12 karakter uzunluğunda olmalıdır";

            int counter = 0;
            Regex pass = new Regex(@"^[^ şçğüöıŞÇĞÜÖİ]{6,12}$");
            string password = txtUserPassword.Text;
            Regex sLetter = new Regex(@"[a-z]");
            Regex cLetter = new Regex(@"[A-Z]");
            Regex number = new Regex(@"[0-9]");
            Regex signs = new Regex(@"[\.]|[\?]|[\\]|[\*]|[\;]|[\,]|[\:]|[-_!']");
            if (pass.IsMatch(password))
            {
                if (sLetter.IsMatch(password)) { counter++; }
                if (cLetter.IsMatch(password)) { counter++; }
                if (number.IsMatch(password)) { counter++; }
                if (signs.IsMatch(password)) { counter++; }
                if (counter >= 3)
                {

                    lblContains.Visible = false;

                }
                else
                {
                    lblContains.Text = "Şifreniz türkçe karkter içermeyen içinde en az bir büyük bir en az \n küçük en az bir özel ve en az bir sayı içeren 6 ila 12 karakter uzunluğunda olmalıdır";

                }
            }
        }

        private void txtUserPassword_Leave(object sender, EventArgs e)
        {
            lblContains.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e) // Çıkış tuşu ekledim.
        {
            Application.Exit();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            Introduction introduction = new Introduction();
            introduction.Show();
            this.Hide();
        }

        public void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtBirthDate.Value < DateTime.Now.AddDays(-365 * 12) && dtBirthDate.Value > DateTime.Now.AddDays(-365 * 18))
            {
                btnContinueToMain.Visible = true;
            }
            else
            {
                MessageBox.Show("12-18 yaş aralığında bir tarih seçilmelidir.");
                btnContinueToMain.Visible = false;
            }
        }
    }
}
