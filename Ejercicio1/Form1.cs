using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboUnidad.Items.Add("km a millas");
            cboUnidad.Items.Add("millas a km");
            cboUnidad.Items.Add("°C a °F");
            cboUnidad.Items.Add("°F a °C");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double valor = Convert.ToDouble(txtCantidad.Text);

            double resultado = 0;

            if (cboUnidad.Text == "km a millas")
            {
                resultado = valor * 0.621371;
                lblResultado.Text = resultado.ToString() + " millas";
            }

            else if (cboUnidad.Text == "millas a km")
            {
                resultado = valor * 1.60934;
                lblResultado.Text = resultado.ToString() + " km";
                

            }

            else if (cboUnidad.Text == "°C a °F")
            {
                resultado = (valor * 9 / 5) + 32;
                lblResultado.Text = resultado.ToString() + " °F";
               
            }

            else if (cboUnidad.Text == "°F a °C")
            {
                resultado = (valor - 32) * 5 / 9;
                lblResultado.Text = resultado.ToString() + " °C";
            }
            
        }
    }
}
