namespace Practica_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal1, cal2, cal3, cal4, promedio;
            cal1 = double.Parse(textBox1.Text);
            cal2 = double.Parse(textBox2.Text);
            cal3 = double.Parse(textBox3.Text);
            cal4 = double.Parse(textBox4.Text);

            promedio = (cal1 + cal2 + cal3 + cal4) / 4;
            if (promedio >= 6)
            {
                if ((cal1 >= 6) && (cal2 >= 6) && (cal3 >= 6) && (cal4 >= 6))
                {
                    MessageBox.Show("Aprobado");
                }
                else { MessageBox.Show("Reprobado"); }
            }
        }
    }
}
