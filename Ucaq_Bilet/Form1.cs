namespace Ucaq_Bilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Yolcu Bilgileri:");
            listBox1.Items.Add("Ad-Soyad: " + textBox1.Text + ", Telefon: " + maskedTextBox2.Text + ", TC: " + maskedTextBox3.Text);
            listBox1.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            listBox1.Items.Add("Uçuþ Bigileri:");
            listBox1.Items.Add("Rota: " + comboBox1.Text + ", " + comboBox2.Text);
            listBox1.Items.Add("Tarih: " + dateTimePicker1.Text + ", " + maskedTextBox1.Text);
            MessageBox.Show("Kayýt baþarýyla yapýlmýþtýr!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label8.Text;
        }
    }
}