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
    public partial class UserControlUpdateİnfo : UserControl
    {
        public UserControlUpdateİnfo()
        {
            InitializeComponent();
        }
        BeslenMeContext db = new BeslenMeContext();
        private void button1_Click(object sender, EventArgs e)
        {
            var getMe = UserEntrance.getUserMail.ToString();
            var getMeuser = db.Users.Where(x => x.User_E_Mail == getMe).Select(x => x.User_E_Mail).FirstOrDefault();
            var getmeUserPassword = db.Users.Where(x => x.User_E_Mail == getMeuser.ToString()).Select(x => x.User_password).FirstOrDefault();
            var getmeUserWeight = db.Users.Where(x => x.User_E_Mail == getMeuser.ToString()).Select(x => x.Weight).FirstOrDefault();
            var getmeUserHeight = db.Users.Where(x => x.User_E_Mail == getMeuser.ToString()).Select(x => x.Height).FirstOrDefault();
            var guncellenicek_kisi = db.Users.Where(w => w.User_E_Mail == getMeuser).FirstOrDefault();
            bool result = (txtOldPassword.Text != null && txtUpdatePassword.Text != null && txtUpdatePasswordAgain.Text != null) ? true : false;
            bool result1 = (txtUpdatePasswordAgain.Text == txtUpdatePassword.Text) ? true : false;
            bool result2 = (txtOldPassword.Text == getmeUserPassword.ToString()) ? true : false;

            if (result && result1 && result2)
            {
                int counter = 0;
                Regex pass = new Regex(@"^[^ şçğüöı]{6,12}$");
                string password = txtUpdatePassword.Text;
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
                        guncellenicek_kisi.User_password = txtUpdatePassword.Text;
                    }
                    else
                    {
                        MessageBox.Show("Daha güçlü parola girin!");
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Parola geçersiz");
                }
            }
            if (nmrUpdateHeight.Value > 220 && nmrUpdateWeight.Value > 150)
            {
                MessageBox.Show("Boy  kilonuz  izin verilen sınırlar dışındadır.");
                nmrUpdateHeight.Value = default;
                nmrUpdateWeight.Value = default;
            }
            guncellenicek_kisi.Weight = (int)nmrUpdateWeight.Value;
            guncellenicek_kisi.Height = (int)nmrUpdateHeight.Value;

            if (guncellenicek_kisi.Gender == true)
            {
                double maleBasalMetabolismRatio = 66.5 + (13.75 * guncellenicek_kisi.Weight) + (5.03 * guncellenicek_kisi.Height) - (6.75 * guncellenicek_kisi.Age);
                guncellenicek_kisi.BasalMetabolism = maleBasalMetabolismRatio;
            }
            else 
            {
                double femaleBasalMetabolismRatio = 655.1 + (9.56 * guncellenicek_kisi.Weight) + (1.85 * guncellenicek_kisi.Height) - (4.68 * guncellenicek_kisi.Age);
                guncellenicek_kisi.BasalMetabolism = femaleBasalMetabolismRatio;
            }
            guncellenicek_kisi.OptimalCal = guncellenicek_kisi.BasalMetabolism * 1.35;

            db.SaveChanges();
            MessageBox.Show("Başarılı bir değişiklik oldu sanırım");
        }
        private void UserControlUpdateİnfo_Load_1(object sender, EventArgs e)
        {
            var getMe = UserEntrance.getUserMail.ToString();
            var getMeuser = db.Users.Where(x => x.User_E_Mail == getMe).Select(x => x.User_E_Mail).FirstOrDefault();
            var getmeUserPassword = db.Users.Where(x => x.User_E_Mail == getMeuser.ToString()).Select(x => x.User_password).FirstOrDefault();
            var getmeUserWeight = db.Users.Where(x => x.User_E_Mail == getMeuser.ToString()).Select(x => x.Weight).FirstOrDefault();
            var getmeUserHeight = db.Users.Where(x => x.User_E_Mail == getMeuser.ToString()).Select(x => x.Height).FirstOrDefault();

            nmrUpdateWeight.Value = getmeUserWeight;
            nmrUpdateHeight.Value = getmeUserHeight;
        }
    }
}
