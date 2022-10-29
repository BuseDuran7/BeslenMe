using Dal;
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
    public partial class UserControlPersonalReport : UserControl
    {
        public UserControlPersonalReport()
        {
            InitializeComponent();
        }
        List<object> degerler1 = new List<object>();
        BeslenMeContext db = new BeslenMeContext();
        private void UserControlPersonalReport_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Meals)
            {
                cmbMeals.Items.Add(item);
            }
            cmbMeals.Items.Add("Tüm Öğünler");
        }
        private void cmbMeals_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        List<DateTime> dateTimes = new List<DateTime>();
        private void btnShowEatenFoods_Click_1(object sender, EventArgs e)
        {
            degerler1.Clear();
            dgvEatenFoods.DataSource = degerler1;

            var getMe = UserEntrance.getUserMail.ToString();
            var getMeuser = db.Users.Where(x => x.User_E_Mail == getMe).Select(x => x.UserID).FirstOrDefault();
            var getCmb = cmbMeals.SelectedIndex + 1;
            var startDate = dtpFirstDate.Value.AddDays(0);
            var endDate = dtpSecondDate.Value.AddDays(0);

            if (startDate > endDate)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden ileri bir tarih seçilemez");
            }
            else if (startDate < endDate)
            {
                if (cmbMeals.SelectedIndex == -1)
                {
                    MessageBox.Show("Öğün Seçimi yapmadınız");
                }
                else if (getCmb < 5)
                {
                    var YEDİKLERİM = db.FoodDetails.Where(obj => obj.EatenDate >= startDate && obj.EatenDate <= endDate).Where(x => x.MealID == getCmb).Where(x => x.UserID == getMeuser).Select(x => new
                    {
                        x.Foods.FoodName,
                        x.Foods.Portion,
                        x.Foods.Calorie,
                        x.Foods.CalorieUnit,
                        x.Foods.Carbs,
                        x.Foods.Fat,
                        x.Foods.Protein,
                        x.Meals.MealName,
                        x.EatenDate
                    }).ToList();

                    degerler1.AddRange(YEDİKLERİM);
                    dgvEatenFoods.DataSource = degerler1.ToList();
                }
                else if (getCmb == 5)
                {
                    var YEDİKLERİM = db.FoodDetails.Where(obj => obj.EatenDate >= startDate && obj.EatenDate <= endDate).Where(x => x.UserID == getMeuser).Select(x => new
                    {
                        x.Foods.FoodName,
                        x.Foods.Portion,
                        x.Foods.Calorie,
                        x.Foods.CalorieUnit,
                        x.Foods.Carbs,
                        x.Foods.Fat,
                        x.Foods.Protein,
                        x.Meals.MealName,
                        x.EatenDate
                    }).ToList();

                    degerler1.AddRange(YEDİKLERİM);
                    dgvEatenFoods.DataSource = degerler1.ToList();
                }
            }
            else if (dtpFirstDate.Value == dtpSecondDate.Value)
            {
                var cDate = dtpSecondDate.Value.AddDays(+1);
                if (cmbMeals.SelectedIndex == -1)
                {
                    MessageBox.Show("Öğün Seçimi yapmadınız");
                }
                else if (getCmb < 5)
                {
                    var YEDİKLERİM = db.FoodDetails.Where(obj => obj.EatenDate >= startDate && obj.EatenDate <= cDate).Where(x => x.MealID == getCmb).Where(x => x.UserID == getMeuser).Select(x => new
                    {
                        x.Foods.FoodName,
                        x.Foods.Portion,
                        x.Foods.Calorie,
                        x.Foods.CalorieUnit,
                        x.Foods.Carbs,
                        x.Foods.Fat,
                        x.Foods.Protein,
                        x.Meals.MealName,
                        x.EatenDate
                    }).ToList();

                    degerler1.AddRange(YEDİKLERİM);
                    dgvEatenFoods.DataSource = degerler1.ToList();
                }
                else if (getCmb == 5)
                {
                    var YEDİKLERİM = db.FoodDetails.Where(obj => obj.EatenDate >= startDate && obj.EatenDate <= cDate).Where(x => x.UserID == getMeuser).Select(x => new
                    {
                        x.Foods.FoodName,
                        x.Foods.Portion,
                        x.Foods.Calorie,
                        x.Foods.CalorieUnit,
                        x.Foods.Carbs,
                        x.Foods.Fat,
                        x.Foods.Protein,
                        x.Meals.MealName,
                        x.EatenDate
                    }).ToList();

                    degerler1.AddRange(YEDİKLERİM);
                    dgvEatenFoods.DataSource = degerler1.ToList();
                }
            }
        }
    }
}
