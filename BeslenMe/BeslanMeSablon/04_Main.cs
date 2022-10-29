using Dal;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeslanMeSablon
{
    public partial class Main : Form
    {
        BeslenMeContext db = new BeslenMeContext();
        public Main(UserEntrance userEntrance)
        {
            InitializeComponent();

            panel4.Location = new Point(panel4.Location.X +0, 0);
            userControlMainPage1.BringToFront();
                                 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(panel4.Location.X + 0, 0);
            userControlMainPage1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(panel4.Location.X + 0, 0+88);
            userControlCalcCalPage1.BringToFront();
         //   this.Close();
        }
        Category category = new Category();
        private void Main_Load(object sender, EventArgs e)
        {
            ////var cp1 = db.Categories.Where(x => x.CategoryID == 1).Select(x => x.PicturePath);
            ////category.PicturePath = @"https://www.shutterstock.com/tr/image-photo/bread-grains-group-11696671";

            //using (WebClient webClient = new WebClient())
            //{
            //    byte[] data = webClient.DownloadData("https://i.lezzet.com.tr/images-xxlarge-secondary/dunyadaki-en-saglikli-14-sebze-e0d2cb87-f048-4473-bb33-a0f65e215b1c.jpg");

            //    using (MemoryStream mem = new MemoryStream(data))
            //    {
            //        using (var yourImage = Image.FromStream(mem))
            //        {    yourImage.Save(@"C:\Users\admin\Desktop\new", ImageFormat.Jpeg);
            //        }
            //    }
            //}

        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(panel4.Location.X + 0, 0 + 176);
            userControlAddMeal1.BringToFront();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(panel4.Location.X + 0, 0 + 352);
            userControlGeneralReport1.BringToFront();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(panel4.Location.X + 0, 0 + 430);
            userControlUpdateİnfo1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Location = new Point(panel4.Location.X + 0, 0 + 264 );
            userControlPersonalReport1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
