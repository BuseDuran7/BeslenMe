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
    public partial class UserControlGeneralReport : UserControl
    {
        public UserControlGeneralReport()
        {
            InitializeComponent();
        }
        BeslenMeContext db = new BeslenMeContext();
        List<object> degerler2 = new List<object>();
        private void UserControlGeneralReport_Load_1(object sender, EventArgs e)
        {
            foreach (var item in db.Meals)
            {
                cmbMeals.Items.Add(item);
            }
            cmbMeals.Items.Add("Tüm Öğünler");

            degerler2.Clear();
            dgvQuery.DataSource = degerler2;
        }
        private void btnMostSelectedFood_Click(object sender, EventArgs e)
        {
            var getCmb = cmbMeals.SelectedIndex + 1;
            var startDate = dtpFirstDate.Value.AddDays(-1);
            var endDate = dtpSecondDate.Value.AddDays(+1);

            if (cmbMeals.SelectedIndex == -1)
            {
                MessageBox.Show("Öğün Seçimi yapmadınız");
            }
            else if (getCmb < 5)
            {
                degerler2.Clear();
                dgvQuery.DataSource = degerler2;
                var query = db.FoodDetails.Where(obj => obj.EatenDate >= startDate && obj.EatenDate <= endDate).Where(x => x.MealID == getCmb)
                       .GroupBy(p => p.Foods.FoodName).OrderByDescending(x => x.Count())
                       .Select(g => new
                       {
                           YemekAdi = g.Key,
                           Adet = g.Count()
                       }).ToList();

                degerler2.AddRange(query);
                dgvQuery.DataSource = degerler2.ToList().Take(1);
            }
            else if (getCmb == 5)
            {
                degerler2.Clear();
                dgvQuery.DataSource = degerler2;
                var query = db.FoodDetails.Where(obj => obj.EatenDate >= startDate && obj.EatenDate <= endDate)
                       .GroupBy(p => p.Foods.FoodName).OrderByDescending(x => x.Count())
                       .Select(g => new
                       {
                           YemekAdi = g.Key,
                           Adet = g.Count()
                       }).ToList().Take(1);

                degerler2.AddRange(query);
                dgvQuery.DataSource = degerler2.ToList();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var getCmb = cmbMeals.SelectedIndex + 1;
            var startDate = dtpFirstDate.Value.AddDays(-1);
            var endDate = dtpSecondDate.Value;
            var getMe = UserEntrance.getUserMail.ToString();
            var getMeuser = db.Users.Where(x => x.User_E_Mail == getMe).Select(x => x.UserID).FirstOrDefault();

            if (cmbMeals.SelectedIndex == -1)
            {
                MessageBox.Show("Öğün Seçimi yapmadınız");
            }
            else if (getCmb < 5)
            {
                degerler2.Clear();
                dgvQuery.DataSource = degerler2;

                var query = db.FoodDetails.Where(obj => obj.EatenDate >= startDate && obj.EatenDate <= endDate).Where(x => x.UserID == getMeuser).Where(x => x.MealID == getCmb)
                       .GroupBy(p => p.Foods.FoodName).OrderByDescending(x => x.Count())
                       .Select(g => new
                       {
                           YemekAdi = g.Key,
                           Adet = g.Count()
                       }).ToList().Take(1);

                degerler2.AddRange(query);
                dgvQuery.DataSource = degerler2.ToList();
            }
            else if (getCmb == 5)
            {
                degerler2.Clear();
                dgvQuery.DataSource = degerler2;

                var query = db.FoodDetails.Where(obj => obj.EatenDate >= startDate && obj.EatenDate <= endDate).Where(x => x.UserID == getMeuser)
                       .GroupBy(p => p.Foods.FoodName).OrderByDescending(x => x.Count())
                       .Select(g => new
                       {
                           YemekAdi = g.Key,
                           Adet = g.Count()
                       }).ToList().Take(5);

                degerler2.AddRange(query);
                dgvQuery.DataSource = degerler2.ToList().Take(1);
            }
        }
    }
}