using Dal;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeslanMeSablon
{
    public partial class UserControlAddMeal : UserControl
    {
        public UserControlAddMeal()
        {
            InitializeComponent();
        }
        BeslenMeContext db = new BeslenMeContext();
        private void UserControlAddMeal_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Meals)
            {
                cmbSelectMeals.Items.Add(item);
            }
            dgvFoodData.DataSource = db.Foods.ToList();
            db.SaveChanges();

            var getDate = dtSelectDate.Value;
            var endDateExclusive = getDate.AddHours(-24);
            var getMe = UserEntrance.getUserMail.ToString();
            var getMeuser = db.Users.Where(x => x.User_E_Mail == getMe).Select(x => x.UserID).FirstOrDefault();
            var getOptimalCalorie = db.Users.Where(x => x.UserID == getMeuser).Select(x => x.OptimalCal).FirstOrDefault();
            var getCalorie = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate > endDateExclusive).Select(x => x.TotalCalorie).ToList();
            double sum1 = 0;

            foreach (var item in getCalorie)
            {
                sum1 += item;

            }
            mainSum = sum1;
        }
        List<object> degerler = new List<object>();
        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchFood.Text == " ")
            {
                dgvFoodData.DataSource = db.Foods.ToList();
                db.SaveChanges();
            }
            var arananYemek = db.Foods.Where(x => x.FoodName.Contains(txtSearchFood.Text)).Select(x => new
            {
                x.FoodID,
                x.FoodName,
                x.Calorie,
                x.Carbs,
                x.Fat,
                x.Protein,
                x.Amount,
                x.Portion
            }).ToList();

            dgvFoodData.DataSource = arananYemek.ToList();
            db.SaveChanges();
        }

        private void dgvFoodData_DoubleClick(object sender, EventArgs e)
        {
            var IdAl = dgvFoodData.CurrentRow.Cells[0].Value;
            var degerleriGetir = db.Foods.Where(x => x.FoodID == (int)IdAl).Select(x => new
            {
                x.FoodID,
                x.FoodName,
                x.Calorie,
                x.Carbs,
                x.Fat,
                x.Protein,
                x.Amount,
                x.Portion
            }).ToList();

            degerler.AddRange(degerleriGetir);
            dgvSelectedFoods.DataSource = degerler.ToList();
        }
        public static double mainSum;
        FoodDetail foodDts = new FoodDetail();
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            var getMe = UserEntrance.getUserMail.ToString();
            var getMeuser = db.Users.Where(x => x.User_E_Mail == getMe).Select(x => x.UserID).FirstOrDefault();

            if (cmbSelectMeals.SelectedIndex == 0 || cmbSelectMeals.SelectedIndex == 1 || cmbSelectMeals.SelectedIndex == 2 || cmbSelectMeals.SelectedIndex == 3)
            {
                for (int i = 0; i < dgvSelectedFoods.Rows.Count; i++)
                {
                    foodDts.FoodID = (int)dgvSelectedFoods.Rows[i].Cells[0].Value;
                    foodDts.UserID = getMeuser;
                    foodDts.MealID = cmbSelectMeals.SelectedIndex + 1;
                    foodDts.Calorie = (double)dgvSelectedFoods.Rows[i].Cells[2].Value;
                    foodDts.Quantity = 1;
                    foodDts.TotalCalorie = foodDts.Quantity * foodDts.Calorie;
                    foodDts.Carbs = (double)dgvSelectedFoods.Rows[i].Cells[3].Value;
                    foodDts.Fat = (double)dgvSelectedFoods.Rows[i].Cells[4].Value;
                    foodDts.Protein = (double)dgvSelectedFoods.Rows[i].Cells[5].Value;
                    foodDts.EatenDate = dtSelectDate.Value;

                    db.FoodDetails.Add(foodDts);
                    db.SaveChanges();
                }
                MessageBox.Show("Öğününüz Başarıyla Eklenmiştir");

                var endDate = dtSelectDate.Value;
                var endDateExclusive = endDate.AddHours(-24);
                var getDate = dtSelectDate.Value;
                var getOptimalCalorie = db.Users.Where(x => x.UserID == getMeuser).Select(x => x.OptimalCal).FirstOrDefault();
                var getCalorie = db.FoodDetails.Where(x => x.UserID == getMeuser).Where(obj => obj.EatenDate >= endDateExclusive && obj.EatenDate <= endDate).Select(x => x.TotalCalorie).ToList();
                double sum1 = 0;

                foreach (var item in getCalorie)
                {
                    sum1 += item;

                }
                mainSum = sum1;
            }
            else { MessageBox.Show("Lütfen Öğün seçiniz"); }
        }
        private void cmbSelectMeals_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            degerler.Clear();
            dgvSelectedFoods.DataSource = degerler;
        }
        private void dgvFoodData_MouseClick(object sender, MouseEventArgs e)
        {
            var catName = (dgvFoodData.CurrentRow.Cells[10].Value).ToString();


            if (catName == "1")
            {
                picForCategories.ImageLocation = "https://i.lezzet.com.tr/images-xxlarge-recipe/eksi-mayali-beyaz-ekmek-a931dc8d-df14-4de0-9cac-f775bdc6a299.jpg";
            }
            else if (catName == "2")
            {
                picForCategories.ImageLocation = "https://www.cumhuriyet.com.tr/Archive/2022/3/14/1915760/kapak_104530.jpg";
            }

            else if (catName == "3")
            {
                picForCategories.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/9/9c/Meyveler.jpg";
            }
            else if (catName == "4")
            {
                picForCategories.ImageLocation = "https://dokuz8habernet.teimg.com/crop/1280x720/dokuz8haber-net/uploads/2022/08/organik-meyve-sebzelerin-farki-nedir-262-2.jpg";
            }
            else if (catName == "5")
            {
                picForCategories.ImageLocation = "http://www.bionaturel.com.tr/wp-content/uploads/revslider/slider1/kuruyemis.jpg";
            }
            else if (catName == "6")
            {
                picForCategories.ImageLocation = "https://i.lezzet.com.tr/images-xxlarge-secondary/aycicek-yagi-yerine-hangi-yaglar-kullanilabilir-7b40f05a-4bba-47b5-b195-90501f9f0f33.jpg";
            }
            else if (catName == "7")
            {
                picForCategories.ImageLocation = "https://im.haberturk.com/2015/02/13/ver1423834413/1042846_620x410.jpg";
            }
            else if (catName == "8")
            {
                picForCategories.ImageLocation = "https://img.internethaber.com/rcman/Cw714h402q95gc/storage/files/images/2021/08/24/beyaz-et-3RBJ_cover.jpg";
            }
            else if (catName == "9")
            {
                picForCategories.ImageLocation = "https://i.cnnturk.com/i/cnnturk/75/740x416/612b1bc579da3e0facb9a587.jpg";
            }
            else if (catName == "10")
            {
                picForCategories.ImageLocation = "https://i.lezzet.com.tr/images-xxlarge-secondary/saglikli-kis-corbalari-sifa-dolu-10-farkli-corba-tarifi-7aabe9cc-1c27-4014-b7e8-4da230381c86.jpg";
            }
            else if (catName == "11")
            {
                picForCategories.ImageLocation = "https://www.neoldu.com/d/other/israil-salatasi.jpg";
            }
            else if (catName == "12")
            {
                picForCategories.ImageLocation = "https://d.neoldu.com/news/23796.jpg";
            }
            else if (catName == "13")
            {
                picForCategories.ImageLocation = "https://i.lezzet.com.tr/images-xxlarge-secondary/tam-tahilli-besinlerle-beslenmenin-faydalari-72fcd55f-7385-4f8d-89e1-ed17a7d56ed3.jpg";
            }
            else if (catName == "14")
            {
                picForCategories.ImageLocation = "https://hthayat.haberturk.com/im/2011/07/30/ver1415179498/653286_620x360.jpg";
            }
            else if (catName == "15")
            {
                picForCategories.ImageLocation = "https://www.sahinsimitsarayi.com/uploads/fileman/kategoriler/toplu-kahvalti-torbali.jpg";
            }

        }
    }
}

