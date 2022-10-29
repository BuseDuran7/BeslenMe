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
    public partial class UserControlCalcCalPage : UserControl
    {
        public UserControlCalcCalPage()
        {
            InitializeComponent();
        }
        BeslenMeContext db;
        List<object> degerler = new List<object>();
        private void UserControlCalcCalPage_Load(object sender, EventArgs e)
        {
            db = new BeslenMeContext();
            dgvFoods.DataSource = db.Foods.ToList();
            db.SaveChanges();
        }
        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            dgvFoods.DataSource = db.Foods.ToList();
            db.SaveChanges();
        }
        private void txtSearchForFood_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchForFood.Text == " ")
            {
                dgvFoods.DataSource = db.Foods.ToList();
                db.SaveChanges();
            }
            var arananYemek = db.Foods.Where(x => x.FoodName.Contains(txtSearchForFood.Text)).Select(x => new
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

            dgvFoods.DataSource = arananYemek.ToList();
            db.SaveChanges();
        }
        private void dgvFoods_DoubleClick(object sender, EventArgs e)
        {
            var IdAl = dgvFoods.CurrentRow.Cells[0].Value;

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
            dgvSelected.DataSource = degerler.ToList();
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            degerler.Clear();
            txtSearchForFood.Text = "";
            dgvSelected.DataSource = degerler;
        }
    }
}

