using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koe3
{
    public partial class Form2 : Form
    {

        private Form1 form1;

        public double Hinta { get; set; }

        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        
        private void btnOK_Click(object sender, EventArgs e) // lasketaan pizzan ja lisukkeiden hinta yhteen
        {
            double kpl, juusto, kinkku, oliivit, juoma05, juoma15;
            kpl = Convert.ToDouble(pizzaMaara.Value);
            juusto = Convert.ToDouble(juustoMaara.Value) * 1;
            kinkku = Convert.ToDouble(kinkkuMaara.Value) * 1.50;
            oliivit = Convert.ToDouble(oliiviMaara.Value) * 0.50;
            juoma05 = 2.50 * kpl;
            juoma15 = 4.00 * kpl;




            if (Form1.IsBtnMargheritaClicked == true) // tarkistetaan mikä pizza on valittu ja lisätään hintaan lisukkeet ja juomat
            {
                Hinta += 11.90 * kpl + juusto + kinkku + oliivit;
                if (checkbox05.Checked)
                {
                    Hinta += juoma05;
                }
                if (checkbox15.Checked)
                {
                    Hinta += juoma15;
                }

                form1.UpdateLabel4(Hinta);
                form1.kassa(Hinta);
                Form1.IsBtnMargheritaClicked = false; // asetetaan boolean arvo takaisin falseksi
                if (kpl > 0)
                {
                    form1.listBox1.Items.Add("Margherita " + kpl + " kpl" + " 11,90€"); // lisätään listboxiin tiedot tilatuista pizzoista ja lisukkeista
                }
                if (juusto > 0)
                {
                    form1.listBox1.Items.Add("Lisäjuusto " + juusto + " kpl" + " 1,00€");
                }
                if (kinkku > 0)
                {
                    form1.listBox1.Items.Add("Kinkku " + kinkku + " kpl" + " 1,50€");
                }
                if (oliivit > 0)
                {
                    form1.listBox1.Items.Add("Oliivit " + oliivit + " kpl" + " 0,50€");
                }
                if (checkbox05.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 0,5l " + kpl + " kpl" + " 2,50€");
                }
                if (checkbox15.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 1,5l " + kpl + " kpl" + " 4,00€");
                }
                
            }

            if (Form1.IsBtnLihamestariClicked == true)
            {
                Hinta += 15.40 * kpl + juusto + kinkku + oliivit;
                if (checkbox05.Checked)
                {
                    Hinta += juoma05;
                }
                if (checkbox15.Checked)
                {
                    Hinta += juoma15;
                }

                form1.UpdateLabel4(Hinta);
                form1.kassa(Hinta);
                Form1.IsBtnLihamestariClicked = false;
                if (kpl > 0)
                {
                    form1.listBox1.Items.Add("Lihamestari " + kpl + " kpl" + " 15,40€");
                }
                if (juusto > 0)
                {
                    form1.listBox1.Items.Add("Lisäjuusto " + juusto + " kpl" + " 1,00€");
                }
                if (kinkku > 0)
                {
                    form1.listBox1.Items.Add("Kinkku " + kinkku + " kpl" + " 1,50€");
                }
                if (oliivit > 0)
                {
                    form1.listBox1.Items.Add("Oliivit " + oliivit + " kpl" + " 0,50€");
                }
                if (checkbox05.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 0,5l " + kpl + " kpl" + " 2,50€");
                }
                if (checkbox15.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 1,5l " + kpl + " kpl" + " 4,00€");
                }
            }

            if (Form1.IsBtnMozzarellaClicked == true)
            {
                Hinta += 14.90 * kpl + juusto + kinkku + oliivit;
                if (checkbox05.Checked)
                {
                    Hinta += juoma05;
                }
                if (checkbox15.Checked)
                {
                    Hinta += juoma15;
                }

                form1.UpdateLabel4(Hinta);
                form1.kassa(Hinta);
                Form1.IsBtnMozzarellaClicked = false;
                if (kpl > 0)
                {
                    form1.listBox1.Items.Add("Mozzarella " + kpl + " kpl" + " 14,90€");
                }
                if (juusto > 0)
                {
                    form1.listBox1.Items.Add("Lisäjuusto " + juusto + " kpl" + " 1,00€");
                }
                if (kinkku > 0)
                {
                    form1.listBox1.Items.Add("Kinkku " + kinkku + " kpl" + " 1,50€");
                }
                if (oliivit > 0)
                {
                    form1.listBox1.Items.Add("Oliivit " + oliivit + " kpl" + " 0,50€");
                }
                if (checkbox05.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 0,5l " + kpl + " kpl" + " 2,50€");
                }
                if (checkbox15.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 1,5l " + kpl + " kpl" + " 4,00€");
                }
            }

            if (Form1.IsBtnOperaClicked == true)
            {
                Hinta += 12.60 * kpl + juusto + kinkku + oliivit;
                if (checkbox05.Checked)
                {
                    Hinta += juoma05;
                }
                if (checkbox15.Checked)
                {
                    Hinta += juoma15;
                }

                form1.UpdateLabel4(Hinta);
                form1.kassa(Hinta);
                Form1.IsBtnOperaClicked = false;
                if (kpl > 0)
                {
                    form1.listBox1.Items.Add("Opera " + kpl + " kpl" + " 12,60€");
                }
                if (juusto > 0)
                {
                    form1.listBox1.Items.Add("Lisäjuusto " + juusto + " kpl" + " 1,00€");
                }
                if (kinkku > 0)
                {
                    form1.listBox1.Items.Add("Kinkku " + kinkku + " kpl" + " 1,50€");
                }
                if (oliivit > 0)
                {
                    form1.listBox1.Items.Add("Oliivit " + oliivit + " kpl" + " 0,50€");
                }
                if (checkbox05.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 0,5l " + kpl + " kpl" + " 2,50€");
                }
                if (checkbox15.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 1,5l " + kpl + " kpl" + " 4,00€");
                }
            }

            if (Form1.IsBtnTropicanaClicked == true)
            {
                Hinta += 12.40 * kpl + juusto + kinkku + oliivit;
                if (checkbox05.Checked)
                {
                    Hinta += juoma05;
                }
                if (checkbox15.Checked)
                {
                    Hinta += juoma15;
                }

                form1.UpdateLabel4(Hinta);
                form1.kassa(Hinta);
                Form1.IsBtnTropicanaClicked = false;
                if (kpl > 0)
                {
                    form1.listBox1.Items.Add("Tropicana " + kpl + " kpl" + " 12,40€");
                }
                if (juusto > 0)
                {
                    form1.listBox1.Items.Add("Lisäjuusto " + juusto + " kpl" + " 1,00€");
                }
                if (kinkku > 0)
                {
                    form1.listBox1.Items.Add("Kinkku " + kinkku + " kpl" + " 1,50€");
                }
                if (oliivit > 0)
                {
                    form1.listBox1.Items.Add("Oliivit " + oliivit + " kpl" + " 0,50€");
                }
                if (checkbox05.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 0,5l " + kpl + " kpl" + " 2,50€");
                }
                if (checkbox15.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 1,5l " + kpl + " kpl" + " 4,00€");
                }
            }

            if (Form1.IsBtnPepperoniClicked == true)
            {
                Hinta += 11.90 * kpl + juusto + kinkku + oliivit;
                if (checkbox05.Checked)
                {
                    Hinta += juoma05;
                }
                if (checkbox15.Checked)
                {
                    Hinta += juoma15;
                }

                form1.UpdateLabel4(Hinta);
                form1.kassa(Hinta);
                Form1.IsBtnPepperoniClicked = false;
                if (kpl > 0)
                {
                    form1.listBox1.Items.Add("Pepperoni " + kpl + " kpl" + " 11,90€");
                }
                if (juusto > 0)
                {
                    form1.listBox1.Items.Add("Lisäjuusto " + juusto + " kpl" + " 1,00€");
                }
                if (kinkku > 0)
                {
                    form1.listBox1.Items.Add("Kinkku " + kinkku + " kpl" + " 1,50€");
                }
                if (oliivit > 0)
                {
                    form1.listBox1.Items.Add("Oliivit " + oliivit + " kpl" + " 0,50€");
                }
                if (checkbox05.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 0,5l " + kpl + " kpl" + " 2,50€");
                }
                if (checkbox15.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 1,5l " + kpl + " kpl" + " 4,00€");
                }
            }

            if (Form1.IsBtnJauhelihaClicked == true)
            {
                Hinta += 11.90 * kpl + juusto + kinkku + oliivit;
                if (checkbox05.Checked)
                {
                    Hinta += juoma05;
                }
                if (checkbox15.Checked)
                {
                    Hinta += juoma15;
                }

                form1.UpdateLabel4(Hinta);
                form1.kassa(Hinta);
                Form1.IsBtnJauhelihaClicked = false;
                if (kpl > 0)
                {
                    form1.listBox1.Items.Add("Jauheliha " + kpl + " kpl" + " 11,90€");
                }
                if (juusto > 0)
                {
                    form1.listBox1.Items.Add("Lisäjuusto " + juusto + " kpl" + " 1,00€");
                }
                if (kinkku > 0)
                {
                    form1.listBox1.Items.Add("Kinkku " + kinkku + " kpl" + " 1,50€");
                }
                if (oliivit > 0)
                {
                    form1.listBox1.Items.Add("Oliivit " + oliivit + " kpl" + " 0,50€");
                }
                if (checkbox05.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 0,5l " + kpl + " kpl" + " 2,50€");
                }
                if (checkbox15.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 1,5l " + kpl + " kpl" + " 4,00€");
                }
            }

            if (Form1.IsBtnAmericanaClicked == true)
            {
                Hinta += 13.40 * kpl + juusto + kinkku + oliivit;
                if (checkbox05.Checked)
                {
                    Hinta += juoma05;
                }
                if (checkbox15.Checked)
                {
                    Hinta += juoma15;
                }

                form1.UpdateLabel4(Hinta);
                form1.kassa(Hinta);
                Form1.IsBtnAmericanaClicked = false;
                if (kpl > 0)
                {
                    form1.listBox1.Items.Add("Americana " + kpl + " kpl" + " 13,40€");
                }
                if (juusto > 0)
                {
                    form1.listBox1.Items.Add("Lisäjuusto " + juusto + " kpl" + " 1,00€");
                }
                if (kinkku > 0)
                {
                    form1.listBox1.Items.Add("Kinkku " + kinkku + " kpl" + " 1,50€");
                }
                if (oliivit > 0)
                {
                    form1.listBox1.Items.Add("Oliivit " + oliivit + " kpl" + " 0,50€");
                }
                if (checkbox05.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 0,5l " + kpl + " kpl" + " 2,50€");
                }
                if (checkbox15.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 1,5l " + kpl + " kpl" + " 4,00€");
                }
            }

            if (Form1.IsBtnKebabClicked == true)
            {
                Hinta += 14.60 * kpl + juusto + kinkku + oliivit;
                if (checkbox05.Checked)
                {
                    Hinta += juoma05;
                }
                if (checkbox15.Checked)
                {
                    Hinta += juoma15;
                }

                form1.UpdateLabel4(Hinta);
                form1.kassa(Hinta);
                Form1.IsBtnKebabClicked = false;
                if (kpl > 0)
                {
                    form1.listBox1.Items.Add("Kebab " + kpl + " kpl" + " 14,60€");
                }
                if (juusto > 0)
                {
                    form1.listBox1.Items.Add("Lisäjuusto " + juusto + " kpl" + " 1,00€");
                }
                if (kinkku > 0)
                {
                    form1.listBox1.Items.Add("Kinkku " + kinkku + " kpl" + " 1,50€");
                }
                if (oliivit > 0)
                {
                    form1.listBox1.Items.Add("Oliivit " + oliivit + " kpl" + " 0,50€");
                }
                if (checkbox05.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 0,5l " + kpl + " kpl" + " 2,50€");
                }
                if (checkbox15.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 1,5l " + kpl + " kpl" + " 4,00€");
                }
            }

            if (Form1.IsBtnPerfettaClicked == true)
            {
                Hinta += 11.90 * kpl + juusto + kinkku + oliivit;
                if (checkbox05.Checked)
                {
                    Hinta += juoma05;
                }
                if (checkbox15.Checked)
                {
                    Hinta += juoma15;
                }

                form1.UpdateLabel4(Hinta);
                form1.kassa(Hinta);
                Form1.IsBtnPerfettaClicked = false;
                if (kpl > 0)
                {
                    form1.listBox1.Items.Add("Perfetta " + kpl + " kpl" + " 11,90€");
                }
                if (juusto > 0)
                {
                    form1.listBox1.Items.Add("Lisäjuusto " + juusto + " kpl" + " 1,00€");
                }
                if (kinkku > 0)
                {
                    form1.listBox1.Items.Add("Kinkku " + kinkku + " kpl" + " 1,50€");
                }
                if (oliivit > 0)
                {
                    form1.listBox1.Items.Add("Oliivit " + oliivit + " kpl" + " 0,50€");
                }
                if (checkbox05.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 0,5l " + kpl + " kpl" + " 2,50€");
                }
                if (checkbox15.Checked)
                {
                    form1.listBox1.Items.Add("Juoma 1,5l " + kpl + " kpl" + " 4,00€");
                }
            }

            Close(); // suljetaan ikkuna kun OK painiketta painetaan
        }

        private void checkbox05_CheckedChanged(object sender, EventArgs e) // tarkistetaan onko checkbox valittu ja estetään toisen checkboxin valinta
        {
            if (checkbox05.Checked)
            {
                checkbox15.Enabled = false;
                
            }
            if (!checkbox05.Checked)
            {
                checkbox15.Enabled = true;
            }

        }

        private void checkbox15_CheckedChanged(object sender, EventArgs e) 
        {
            if (checkbox15.Checked)
            {
                checkbox05.Enabled = false;
            }
            if (!checkbox15.Checked)
            {
                checkbox05.Enabled = true;
            }
        }
    }
}
