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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Close();
        }

        public string basNoktasiLocal;
        public string bitNoktasiLocal;
        private void button1_Click(object sender, EventArgs e)
        {

            Trip trip = new Trip();
            Route route = new Route();

            bool basVar = false;
            bool bitVar = false;

            foreach (string durak in trip.sefer1)
            {
                if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                {
                    basVar = true;
                }
                else if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                {
                    bitVar = true;
                }

                if (basVar && bitVar)
                {
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Kocaeli")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Bilecik")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 150;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Ankara")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 250;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Eskişehir")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 200;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Konya")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 300;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "İstanbul")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Bilecik")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Ankara")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 200;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Eskişehir")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 100;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Konya")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 250;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Bilecik" && comboBox2.Text == "İstanbul")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 150;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Kocaeli")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Ankara")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 150;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Eskişehir")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Konya")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 200;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Ankara" && comboBox2.Text == "İstanbul")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 250;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Ankara" && comboBox2.Text == "Kocaeli")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 200;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Ankara" && comboBox2.Text == "Bilecik")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 150;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Ankara" && comboBox2.Text == "Eskişehir")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 100;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "İstanbul")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 200;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Kocaeli")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 100;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Bilecik")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Ankara")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 100;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Konya")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 150;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Konya" && comboBox2.Text == "İstanbul")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 300;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Konya" && comboBox2.Text == "Kocaeli")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 250;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Konya" && comboBox2.Text == "Bilecik")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 200;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                    else if (comboBox1.Text == "Konya" && comboBox2.Text == "Eskişehir")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 150;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                    }
                }
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                row.Cells[0].Value = trip.firma.ToString();
                row.Cells[4].Value = trip.fiyat;
                row.Cells[1].Value = trip.tasitNo;
                row.Cells[2].Value = trip.koltukNo;
                row.Cells[3].Value = 1;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
