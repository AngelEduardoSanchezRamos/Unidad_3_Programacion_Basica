namespace Practica_14___Selectivas_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal;
            cal = double.Parse(textBox1.Text);
            if (cal < 6.0) MessageBox.Show(" Reponbado");
            else MessageBox.Show("Aprobado");
        }
    }
}
