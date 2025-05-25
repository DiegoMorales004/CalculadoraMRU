using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace CalculadorMRU
{
    public partial class FormMRU : Form
    {
        public FormMRU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {

            bool lResultado = false;

            lResultado = ValidaExistenciaInformacion();

            if (!lResultado) return;

            CalcularMRU();

        }



        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarControles();
            // Permitir números, control (como backspace), y un solo punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarControles();
            // Permitir números, control (como backspace), y un solo punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtVelocidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarControles();
            // Permitir números, control (como backspace), y un solo punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private bool ValidaExistenciaInformacion()
        {
            int lValorUno = 0;
            int lValorDos = 0;
            int lValorTres = 0;
            int total = 0;

            lValorUno = txtDistancia.Text.Length > 0 ? 1 : 0;
            lValorDos = txtTiempo.Text.Length > 0 ? 1 : 0;
            lValorTres = txtVelocidad.Text.Length > 0 ? 1 : 0;

            total = lValorUno + lValorDos + lValorTres;

            if (total == 3)
            {
                MessageBox.Show("Me has dado todos los valores.... necesito una incognita.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (total < 2)
            {
                MessageBox.Show("Es necesario que se ingresen al menos dos datos....", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private void CalcularMRU()
        {
            // Intentamos convertir los valores si existen
            bool tieneVelocidad = decimal.TryParse(txtVelocidad.Text, out decimal v);
            bool tieneDistancia = decimal.TryParse(txtDistancia.Text, out decimal x);
            bool tieneTiempo = decimal.TryParse(txtTiempo.Text, out decimal t);

            if (tieneDistancia && tieneTiempo && !tieneVelocidad)
            {
                // v = x / t
                if (t != 0)
                {
                    txtVelocidad.Text = (x / t).ToString("0.##");
                    txtVelocidad.BackColor = Color.Green;
                    txtVelocidad.ForeColor = Color.White;
                }
                else
                {
                    MessageBox.Show("El tiempo no puede ser cero.");
                }
            }
            else if (tieneVelocidad && tieneTiempo && !tieneDistancia)
            {
                // x = v * t
                txtDistancia.Text = (v * t).ToString("0.##");
                txtDistancia.BackColor = Color.Green;
                txtDistancia.ForeColor = Color.White;
            }
            else if (tieneDistancia && tieneVelocidad && !tieneTiempo)
            {
                // t = x / v
                if (v != 0)
                {
                    txtTiempo.Text = (x / v).ToString("0.##");
                    txtTiempo.BackColor = Color.Green;
                    txtTiempo.ForeColor = Color.White;
                }
                else
                {
                    MessageBox.Show("La velocidad no puede ser cero.");
                }
            }
            else
            {
                MessageBox.Show("Completa solo dos campos para calcular el tercero.");
            }
        }

        private void txtVelocidad_TextChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarControles()
        {
            txtTiempo.ForeColor = Color.Black;
            txtVelocidad.ForeColor = Color.Black;
            txtDistancia.ForeColor = Color.Black;

            txtTiempo.BackColor = Color.White;
            txtVelocidad.BackColor = Color.White;
            txtDistancia.BackColor = Color.White;

        }
    }


}
