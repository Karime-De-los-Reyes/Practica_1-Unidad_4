namespace Practica_1_Unidad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            desactivarControles();
        }
        private double monto;

        private void activarControles()
        {
            textCliente.Enabled = false;
            textMonto.Enabled = false;
            btnAbrir.Enabled = false;

            btnDeposito.Enabled = true;
            btnRetiro.Enabled = true;
        }
        private void desactivarControles()
        {
            textCliente.Enabled = true;
            textMonto.Enabled = true;
            btnAbrir.Enabled = true;

            btnDeposito.Enabled = false;
            btnRetiro.Enabled = false;
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string cliente;
            //Leer los datos
            cliente = textCliente.Text;
            monto = Convert.ToDouble(textMonto.Text);

            if (monto > 0)
            {
                activarControles();
            }
            else
            {
                MessageBox.Show("El monto debe ser mayor o igual a cero ", "Gestión de ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Double leer(string mensaje)
        {
            Double cantidad;
            cantidad = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese monto a " + mensaje, "Gestión de ahorros ", "0", 100, 0));
            return cantidad;
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Double deposito;
            deposito = leer("Depositar");
            monto = monto + deposito;
            listDepositos.Items.Add(deposito);
            mostrar();
        }

        private void mostrar()
        {
            txtSaldo.Text = Convert.ToString(monto);
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            Double retiro;
            retiro = leer("Retirar");

            //Evaluamos
            if (retiro <= monto)
            {
                monto = monto - retiro;
                listRetiros.Items.Add(retiro);
                mostrar();
            }
            else
            {
                MessageBox.Show("La cantidad de retiro es mayor al monto disponible", "Gestión de ahorros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textCliente.Clear();
            textMonto.Clear();
            txtSaldo.Clear();
            listDepositos.Items.Clear();
            listRetiros.Items.Clear();
            desactivarControles();
        }
    }
}