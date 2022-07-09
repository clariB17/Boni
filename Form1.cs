using System.Text.RegularExpressions;

namespace Boni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            if (frecuencia.Text.Length == 0)
            {
                label3.Visible = true;
            }
            else if (distancia.Text.Length == 0)
            {
                label4.Visible = true;
            }
            else
            {
                Zona zona = new Zona();
                zona.Frecuencia = Convert.ToDouble(frecuencia.Text);
                zona.Distancia = Convert.ToDouble(distancia.Text);
                zona.Calculo = 17.32 * Math.Sqrt(zona.Distancia / (4 * zona.Frecuencia));
                DialogResult dialogResult = MessageBox.Show("Para nuestro enlace de  " + zona.Distancia + "km el radio de la zona de Fresnel que deberemos tener libre en el punto medio del enlace será de " + Math.Round(zona.Calculo, 2) + "m");
            }
        }

        public void frecuencia_TextChanged(object sender, EventArgs e)
        {

        }


        private void distancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void frecuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!frecuencia.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos");
            }
        }

        private void distancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}