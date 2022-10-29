using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeslanMeSablon
{
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }
        private void Introduction_Load(object sender, EventArgs e)
        {
            lblInformation.Text = "Bu uygulama 12-18 yaş aralığındaki ergenlik çağındaki bireylerin kişisel bilgilerini baz alarak (boy, kilo, cinsiyet, yaş, ad, soyad) sağlıklı beslenmeyi hayatlarında bir alışkanlık haline getirebilmesi için aldıkları besinlerin ürün bazlı kalorisini hesaplayarak, kişisel bilgiler üzerinden alması gereken kalori miktarı ile kıyaslayarak ve kendilerini belirli periyotlarda (günlük, haftalık, aylık) kontrol edip aynı zamanda diğer kullanıcılarla kıyaslayabileceği ve bunların sonucunda kişinin beslenme tipi üzerinden öneriler veren bir uygulamadır.";
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            UserEntrance userEntrance = new UserEntrance();
            userEntrance.Show();
            this.Hide();
        }
    }
}
