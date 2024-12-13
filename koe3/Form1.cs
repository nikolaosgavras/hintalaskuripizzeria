using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace koe3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public static bool IsBtnMargheritaClicked { get; set; } = false;
        public static bool IsBtnLihamestariClicked { get; set; } = false;
        public static bool IsBtnMozzarellaClicked { get; set; } = false;
        public static bool IsBtnOperaClicked { get; set; } = false;
        public static bool IsBtnTropicanaClicked { get; set; } = false;
        public static bool IsBtnPepperoniClicked { get; set; } = false;
        public static bool IsBtnJauhelihaClicked { get; set; } = false;
        public static bool IsBtnAmericanaClicked { get; set; } = false;
        public static bool IsBtnKebabClicked { get; set; } = false;
        public static bool IsBtnPerfettaClicked { get; set; } = false;

        public void UpdateLabel4(double text)
        {

            string text1 = txtYhteensa.Text.Replace(" €", "");
            if (double.TryParse(text1, out double text2))
            {
                text2 += text;
            }
            else
            {
                text2 = text;
            }

            txtYhteensa.Text = text2.ToString("C");

        }

        public void kassa(double text)
        {
            string text1 = txtKassa.Text.Replace(" €", "");
            if (double.TryParse(text1, out double text2))
            {
                text2 += text;
            }
            else
            {
                text2 = text;
            }

            txtKassa.Text = text2.ToString("C");
        }

        private void btnNollaa_Click(object sender, EventArgs e)
        {

            txtYhteensa.Text = "";
            listBox1.Items.Clear();

        }


        public void btnMargherita_Click(object sender, EventArgs e)
        {
            IsBtnMargheritaClicked = true;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
            
        }

        private void btnLihamestari_Click(object sender, EventArgs e)
        {
            IsBtnLihamestariClicked = true;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void btnMozzarella_Click(object sender, EventArgs e)
        {
            IsBtnMozzarellaClicked = true;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void btnOpera_Click(object sender, EventArgs e)
        {
            IsBtnOperaClicked = true;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void btnTropicana_Click(object sender, EventArgs e)
        {
            IsBtnTropicanaClicked = true;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void btnPepperoni_Click(object sender, EventArgs e)
        {
            IsBtnPepperoniClicked = true;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void btnJauheliha_Click(object sender, EventArgs e)
        {
            IsBtnJauhelihaClicked = true;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void btnAmericana_Click(object sender, EventArgs e)
        {
            IsBtnAmericanaClicked = true;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void btnKebab_Click(object sender, EventArgs e)
        {
            IsBtnKebabClicked = true;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void btnPerfetta_Click(object sender, EventArgs e)
        {
            IsBtnPerfettaClicked = true;
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        
    }
}
