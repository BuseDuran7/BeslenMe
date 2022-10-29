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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
            DateTime BirhtDate = new DateTime(2000,8,30);

            TimeSpan diff;
            int age;

            DateTime calcAge;

            calcAge = BirhtDate;

            diff = DateTime.Now.Date.Subtract(BirhtDate);

            age = Convert.ToInt32(diff.TotalDays);

            int Age = age / 365;

            MessageBox.Show("" + Age);
        }
        {
    }
}
