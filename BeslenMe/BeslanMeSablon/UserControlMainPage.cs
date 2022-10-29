using Dal;
using Data;
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
    public partial class UserControlMainPage : UserControl
    {
        
        public UserControlMainPage()
        {
            InitializeComponent();

        }
        BeslenMeContext db = new BeslenMeContext();
        User user = new User();

        public void UserControlMainPage_Load(object sender, EventArgs e)
        {
            var getMe = UserEntrance.getUserMail.ToString();//user getir
            var getMeuser = db.Users.Where(x => x.User_E_Mail == getMe).Select(x => x.UserID).FirstOrDefault();
            var endDate = DateTime.Now;
            var getMeUserAge = db.Users.Where(x => x.User_E_Mail == getMe).Select(x => x.Age).FirstOrDefault();

            var endDateExclusive = endDate.AddDays(-1);
            var getOptimalCalorie = db.Users.Where(x => x.UserID == getMeuser).Select(x => x.OptimalCal).FirstOrDefault();
            var getCalorie = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.TotalCalorie).ToList();///güne göre getir
            var getFat = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.Fat).ToList();///güne göre getir
            var getCarb = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.Carbs).ToList();///güne göre getir
            var getProtein = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.Protein).ToList();///güne göre getir
            circularProgressBar1.Maximum = (int)getOptimalCalorie;

            double sumForCalori1 = 0;
            foreach (var item in getCalorie)
            {
                sumForCalori1 += item;
            }
            double sumForCalori = 0;
            foreach (var item in getCalorie)
            {
                sumForCalori += item;
                if ((int)getOptimalCalorie < (int)sumForCalori)
                {
                    circularProgressBar1.Value = (int)getOptimalCalorie;
                    circularProgressBar1.ProgressColor = Color.Red;
                }
                else
                {
                    circularProgressBar1.Value = (int)sumForCalori;
                }
            }
            lblSumCal.Text = sumForCalori.ToString();

            double sumForCarbs = 0;
            foreach (var item in getCarb)
            {
                sumForCarbs += item;
            }
            lblCarbs.Text = sumForCarbs.ToString();

            double sumForFat = 0;
            foreach (var item in getFat)
            {
                sumForFat += item;
            }
            lblSumFat.Text = sumForFat.ToString();

            double sumForProtein = 0;
            foreach (var item in getProtein)
            {
                sumForProtein += item;
            }
            lblSumPro.Text = sumForProtein.ToString();
            lblOptiCal.Text = getOptimalCalorie.ToString();

            if (getMeUserAge > 15 &&  getMeUserAge <= 18)
            {
                if (sumForCarbs < 130)
                {
                    rtxtCarbs.Text = "Günlük almanız gereken karbonhidrat miktarı seviyesinin altında kaldınız. Daha fazla karbonhidrat besin içeriği yönünden zengin besinlerle beslenmelesiniz çünkü bu yaşlarda anlık enerji tüketimi fazla olabiliyor ve bunu da karbonhidratla karşılayabilirsiniz. Tahıl ürünleri, meyve ve sebze tüketiminizi arttırarak günlük eksik olan karbonhidrat ihtiyacınızı giderebilirsiniz.";

                }
                else if (sumForCarbs > 160)
                {
                    rtxtCarbs.Text = "Günlük almanız gereken karbonhidrat miktarını geçmiş bulunmaktasınız. Daha fazla karbonhidrat içeren besinlerden uzak durmaya çalışın. Sağlıklı günler dileriz. Tahıl ürünleri, meyve ve sebze tüketiminizi azaltarak günlük fazla olarak almış olduğunuz karbonhidrat miktarını azaltabilirsiniz.";
                }
                if (sumForProtein > 60)
                {
                    rtxtProtein.Text = "Günlük almanız gereken protein miktarını geçmiş bulunmaktasınız. Daha fazla protein içeriğine sahip besinlerden uzak durmaya çalışın. Kas gelişimi ve gücü için aşırı protein tüketimi sağlık açısından kesinlikle önerilmemektedir. Bunun yanı sıra ihtiyaç fazlası protein tüketimi ilerleyen yaşlarda böbrek taşı oluşumuna yol açabilir. Et ve süt ürünleri protein miktarı fazla olan besinlerdir. Bu ürünlerin tüketimini azaltarak günlük fazla almış olduğunuz protein miktarını dengelemiş olursunuz.";
                }
                else if (sumForProtein < 50)
                {
                    rtxtProtein.Text = "Günlük almanız gereken protein miktarından daha azını tüketmiş durumdasınız. Daha fazla protein içeriğine sahip besinler tüketmeye özen gösterin. Protein eksikliği konsantrasyon eksikliğine yol açabilir bu da sınavlarınızda ve derslerinizde sizi olumsuz yönde etkileyebilir. Aynı zamanda protein eksikliği bulunan insanlarda uyku kalitesi olumsuz yönde etkilenir. Et, süt ürünleri ve baklagil tüketimini arttırarak günlük almanız gereken protein miktarını arttırmış olursunuz.";
                }
                if (sumForFat > 70)
                {
                    rtxtFat.Text = "Günlük almanız gereken yağ miktarını geçmiş bulunmaktasınız. Daha fazla yağ içeren besinlerden uzak durmaya çalışın. Fazla yağlı beslenmek kalp-damar hastalıklarının ve kolesterolun ortaya çıkmasına sebep olur. Süt ve süt ürünleri de proteinin yanı sıra fazlaca yağ içeriğine sahiptir.";
                }
                else if (sumForFat < 50)
                {
                    rtxtFat.Text = "Günlük almanız gereken yağ miktarının altında kalmış durumdasınız. Daha fazla yağ içeriğine sahip besinler tüketmeye çalışın. Yağ fazlalığının sonucu hastalıklara neden olduğu gibi eksikliği de başka tür hastalıklara yol açabilir. Az yağ tüketimi sonucu kuru ve sağlıksız bir cilt yapısı ortaya çıkar. Bunların dışında baş ağrısı, halsizlik ve bitkinliğe yol açar. Kuruyemiş ve deniz mahsülleri yağ içeriği bakımından zengin besinlerdir.";
                }
            }
            else if (getMeUserAge >= 12 && getMeUserAge <= 15)
            {
                if (sumForCarbs < 130)
                {
                    rtxtCarbs.Text = "Günlük almanız gereken karbonhidrat miktarı seviyesinin altında kaldınız. Daha fazla karbonhidrat besin içeriği yönünden zengin besinlerle beslenmelesiniz çünkü bu yaşlarda anlık enerji tüketimi fazla olabiliyor ve bunu da karbonhidratla karşılayabilirsiniz. Tahıl ürünleri, meyve ve sebze tüketiminizi arttırarak günlük eksik olan karbonhidrat ihtiyacınızı giderebilirsiniz.";
                }
                else if (sumForCarbs > 160)
                {
                    rtxtCarbs.Text = "Günlük almanız gereken karbonhidrat miktarını geçmiş bulunmaktasınız. Daha fazla karbonhidrat içeren besinlerden uzak durmaya çalışın. Sağlıklı günler dileriz. Tahıl ürünleri, meyve ve sebze tüketiminizi azaltarak günlük fazla olarak almış olduğunuz karbonhidrat miktarını azaltabilirsiniz.";
                }
                if (sumForProtein > 50)
                {
                    rtxtProtein.Text = "Günlük almanız gereken protein miktarını geçmiş bulunmaktasınız. Daha fazla protein içeriğine sahip besinlerden uzak durmaya çalışın. Kas gelişimi ve gücü için aşırı protein tüketimi sağlık açısından kesinlikle önerilmemektedir. Bunun yanı sıra ihtiyaç fazlası protein tüketimi ilerleyen yaşlarda böbrek taşı oluşumuna yol açabilir. Et ve süt ürünleri protein miktarı fazla olan besinlerdir. Bu ürünlerin tüketimini azaltarak günlük fazla almış olduğunuz protein miktarını dengelemiş olursunuz.";
                }
                else if (sumForProtein < 30)
                {
                    rtxtProtein.Text = "Günlük almanız gereken protein miktarından daha azını tüketmiş durumdasınız. Daha fazla protein içeriğine sahip besinler tüketmeye özen gösterin. Protein eksikliği konsantrasyon eksikliğine yol açabilir bu da sınavlarınızda ve derslerinizde sizi olumsuz yönde etkileyebilir. Aynı zamanda protein eksikliği bulunan insanlarda uyku kalitesi olumsuz yönde etkilenir. Et, süt ürünleri ve baklagil tüketimini arttırarak günlük almanız gereken protein miktarını arttırmış olursunuz.";
                }
                if (sumForFat > 70)
                {
                    rtxtFat.Text = "Günlük almanız gereken yağ miktarını geçmiş bulunmaktasınız. Daha fazla yağ içeren besinlerden uzak durmaya çalışın. Fazla yağlı beslenmek kalp-damar hastalıklarının ve kolesterolun ortaya çıkmasına sebep olur. Süt ve süt ürünleri de proteinin yanı sıra fazlaca yağ içeriğine sahiptir.";
                }
                else if (sumForFat < 50)
                {
                    rtxtFat.Text = "Günlük almanız gereken yağ miktarının altında kalmış durumdasınız. Daha fazla yağ içeriğine sahip besinler tüketmeye çalışın. Yağ fazlalığının sonucu hastalıklara neden olduğu gibi eksikliği de başka tür hastalıklara yol açabilir. Az yağ tüketimi sonucu kuru ve sağlıksız bir cilt yapısı ortaya çıkar. Bunların dışında baş ağrısı, halsizlik ve bitkinliğe yol açar. Kuruyemiş ve deniz mahsülleri yağ içeriği bakımından zengin besinlerdir.";
                }
            }
            rtxtHealthyLife.Text = "* Yeterli ve dengeli beslenme besin çeşitliliğine dayanmaktadır.\n\n* Büyüme ve gelişmenizde besin gruplarını önerilen miktarda tüketmenin yanı sıra enerji dengenizin sağlanmasında düzenli fiziksel aktivite alışkanlığının kazanılması da gerekmektedir.\n\n* Okul çağında yapılan düzenli fiziksel aktivite; ilerleyen yaşlarda sağlığınızın korunması ve geliştirilmesinde ve olası sağlık risklerinin önlenmesinde önem taşır.\n\n* Süt ve ürünleri grubu: Bu grup yüksek kalitede protein, kalsiyum, fosfor, çinko, B2, B6, B12 vitamini olmak üzere birçok besin ögesi için iyi bir kaynaktır.\n\n* Süt ve ürünleri grubu: A, E ve K vitaminlerini de içerir. Çocuk ve adölesan(ergenlik) döneminde kemik ve diş sağlığı için önemlidir.\n\n* Süt ve ürünleri grubu: Tüketilmesi önerilen günlük miktar; okul çağı çocukları ve ergenler için 3 porsiyondur.\n\n* Süt ve ürünleri grubu: 12-18 yaş grubu çocuklar haftada 2 gün kahvaltıda süt içmelidir. Sabah kahvaltıda süt içildiğinde meyve çayı, meyve suyu, ıhlamur verilmesine gerek yoktur.\n\n* Et, yumurta, kurubaklagiller ve yağlı tohumlar grubu: Et, tavuk, balık, yumurta, kuru fasulye, nohut, mercimek gibi besinlerin yanı sıra ceviz, fındık, fıstık gibi yağlı tohumları içerir.\n\n* Et, yumurta, kurubaklagiller ve yağlı tohumlar grubu: Bu grup iyi kaliteli protein, demir, çinko, fosfor, magnezyum gibi mineraller ile B1, B6, B12 ve A vitamini için iyi bir kaynaktır.\n\n* Et, yumurta, kurubaklagiller ve yağlı tohumlar grubu:Hücre yenilenmesi, doku onarımı ve görme işlevinde, kan yapımında, sinir sistemi, sindirim sistemi ve deri sağlığında görevi olan besin ögeleri en çok bu grupta bulunur.\n\n* Et, yumurta, kurubaklagiller ve yağlı tohumlar grubu:Yumurta protein kalitesi en yüksek olan besindir. Bunun için çocukların her gün bir adet yumurta tüketmesi önerilir.\n\n* Et, yumurta, kurubaklagiller ve yağlı tohumlar grubu:Kurubaklagillerin yağ içeriği düşük, bitkisel protein ve posa içeriği yüksektir.Kalsiyum, çinko, magnezyum, demir ve B grubu vitaminleri(B12 vitamini hariç) yönünden de zengindir.\n\n* Et, yumurta, kurubaklagiller ve yağlı tohumlar grubu:Yağlı tohumlar daha çok B grubu vitaminleri, mineraller ve yağ içermektedir.\n\n* Et, yumurta, kurubaklagiller ve yağlı tohumlar grubu:Tüketilmesi önerilen günlük miktarlar yaş gruplarına göre değişmekle birlikte; okul çağı çocuklar ve ergenler için et - tavuk - balık - yumurta için; 1.5 - 2 porsiyon, kurubaklagiller için; 3 porsiyon ve yağlı tohumlar için; 0.5 - 1 porsiyondur.\n\n* Sebze ve meyve grubu: Bitkilerin her türlü yenilebilen kısmı sebze ve meyve grubunda yer almaktadır. Bu grupta yer alan besinlerin bileşimlerinin önemli bir bölümü sudur.\n\n* Sebze ve meyve grubu: Özellikle fosfat, A, E, C, B2 vitamini, potasyum, demir, magnezyum ve posadan zengindir.\n\n* Sebze ve meyve grubu: Hücre yenilenmesi, doku onarımı, deri ve göz sağlığı, diş ve diş eti sağlığı, hastalıklara karşı direncin oluşumunda etkindir. Posa içeriği nedeni ile bağırsak çalışmasının düzenlenmesine yardımcı olur.\n\n* Sebze ve meyve grubu: Sebzeler için tüketilmesi önerilen günlük miktarlar yaş gruplarına göre değişmekle birlikte; erkek için ortalama 2 - 4 porsiyon ve kızlar için ortalama 2 - 3.5 porsiyondur.\n\n* Sebze ve meyve grubu: Meyveler için tüketilmesi önerilen günlük miktarlar yaş gruplarına göre değişmekle birlikte okul çağı çocuklar ve ergen erkekler için ortalama 2 - 3 porsiyon ve kızlar için ortalama 2 - 2.5 porsiyondur.\n\n* Ekmek ve tahıllar grubu: Ekmek, pirinç, makarna, erişte, kuskus, bulgur, yulaf, arpa ve kahvaltılık tahılları içerir.Bu grup vitaminler, mineraller, karbonhidratlar(nişasta, posa) ve diğer besin ögelerini sağlamaktadır.\n\n* Ekmek ve tahıllar grubu: Tahıllar vücudun temel enerji kaynağıdır. Tüketilmesi önerilen günlük miktarlar yaş gruplarına göre değişmekle birlikte; okul çağı çocuklar ve ergen erkekler için ortalama 2.5 - 8 porsiyon ve kızlar için ortalama 2.5 - 5 porsiyondur. ";
  
        }

        private void UserControlMainPage_MouseHover(object sender, EventArgs e)
        {
            var getMe = UserEntrance.getUserMail.ToString();
            var getMeuser = db.Users.Where(x => x.User_E_Mail == getMe).Select(x => x.UserID).FirstOrDefault();
            var endDate = DateTime.Now;
            var endDateExclusive = endDate.AddDays(-1);
            var getOptimalCalorie = db.Users.Where(x => x.UserID == getMeuser).Select(x => x.OptimalCal).FirstOrDefault();
            var getCalorie = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.TotalCalorie).ToList();
            var getFat = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.Fat).ToList();
            var getCarb = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.Carbs).ToList();
            var getProtein = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.Protein).ToList();
            circularProgressBar1.Maximum = (int)getOptimalCalorie;

            double sumForCalori1 = 0;
            foreach (var item in getCalorie)
            {
                sumForCalori1 += item;
            }
            double sumForCalori = 0;
            foreach (var item in getCalorie)
            {
                sumForCalori += item;
                if ((int)getOptimalCalorie < (int)sumForCalori)
                {
                    circularProgressBar1.Value = (int)getOptimalCalorie;
                    circularProgressBar1.ProgressColor = Color.Red;
                }
                else
                {
                    circularProgressBar1.Value = (int)sumForCalori;
                }
            }
            lblSumCal.Text = sumForCalori.ToString();

            double sumForCarbs = 0;
            foreach (var item in getCarb)
            {
                sumForCarbs += item;

            }
            lblCarbs.Text = sumForCarbs.ToString();

            double sumForFat = 0;
            foreach (var item in getFat)
            {
                sumForFat += item;
            }
            lblSumFat.Text = sumForFat.ToString();

            double sumForProtein = 0;
            foreach (var item in getProtein)
            {
                sumForProtein += item;
            }
            lblSumPro.Text = sumForProtein.ToString();
            lblOptiCal.Text = getOptimalCalorie.ToString();
        }
        private void UserControlMainPage_MouseMove(object sender, MouseEventArgs e)
        {

            var getMe = UserEntrance.getUserMail.ToString();
            var getMeuser = db.Users.Where(x => x.User_E_Mail == getMe).Select(x => x.UserID).FirstOrDefault();
            var endDate = DateTime.Now;
            var endDateExclusive = endDate.AddDays(-1);
            var getOptimalCalorie = db.Users.Where(x => x.UserID == getMeuser).Select(x => x.OptimalCal).FirstOrDefault();
            var getCalorie = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.TotalCalorie).ToList();
            var getFat = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.Fat).ToList();
            var getCarb = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.Carbs).ToList();
            var getProtein = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.Protein).ToList();
            circularProgressBar1.Maximum = (int)getOptimalCalorie;

            double sumForCalori1 = 0;
            foreach (var item in getCalorie)
            {
                sumForCalori1 += item;
            }

            double sumForCalori = 0;
            foreach (var item in getCalorie)
            {
                sumForCalori += item;
                if ((int)getOptimalCalorie < (int)sumForCalori)
                {
                    circularProgressBar1.Value = (int)getOptimalCalorie;
                    circularProgressBar1.ProgressColor = Color.Red;
                }
                else
                {
                    circularProgressBar1.Value = (int)sumForCalori;
                }
            }
            lblSumCal.Text = sumForCalori.ToString();

            double sumForCarbs = 0;
            foreach (var item in getCarb)
            {
                sumForCarbs += item;

            }
            lblCarbs.Text = sumForCarbs.ToString();

            double sumForFat = 0;
            foreach (var item in getFat)
            {
                sumForFat += item;
            }
            lblSumFat.Text = sumForFat.ToString();

            double sumForProtein = 0;
            foreach (var item in getProtein)
            {
                sumForProtein += item;
            }
            lblSumPro.Text = sumForProtein.ToString();
            lblOptiCal.Text = getOptimalCalorie.ToString();
        }
    }
}
