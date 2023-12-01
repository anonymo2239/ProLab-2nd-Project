using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab_Proje_2_GoPassage
{
    public partial class AdminGirişEkrani : Form
    {
        public AdminGirişEkrani()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPaneli adminPaneli = new AdminPaneli();
            adminPaneli.Show();
            this.Hide();
        }
    }
}
