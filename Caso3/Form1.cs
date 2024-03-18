using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            PrestamoJM jm = new PrestamoJM();
            jm.Cliente = txtCliente.Text;
            jm.MontoSolicitado = double.Parse(txtMontoSolicitado.Text);
            jm.TiempoDuracion = int.Parse(txtTiempo.Text);
            jm.TipoMoneda = cbTipoMoneda.Text;
            txtCuota.Text = jm.PagoMensual().ToString();
        }
    }
}
