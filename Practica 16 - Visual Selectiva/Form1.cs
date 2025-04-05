using System.Diagnostics.Eventing.Reader;

namespace Practica_16___Visual_Selectiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textBox1.Text);
            if (num % 2 == 0) MessageBox.Show("El numero es par");
            else
                if (num % 3 == 0) MessageBox.Show("El numero es impar y es divisible por 3");
            else MessageBox.Show("El numero es impar no divisible por 3");
        }
    }
}
