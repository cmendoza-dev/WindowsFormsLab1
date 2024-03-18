using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double renum;
        double aport;
        double neto;
        double rem;
        double aports;
        double nt;

        void Afp()
        {
            AFP aFP = new AFP();
            aFP.Empleado = txtEmpleado.Text;
            aFP.Categoria = cbCategoria.Text;
            aFP.Basico = double.Parse(txtBasico.Text);
            aFP.Bonificacion = double.Parse(txtBonificacion.Text);
            txtRemuneracion.Text = aFP.Remuneracion().ToString(); // Calcula la remuneración
            txtAportacion.Text = aFP.Descuento().ToString(); // Calcula el descuento
            txtNeto.Text = aFP.Neto().ToString(); // Calcula el neto

        }


        void Onp()
        {
            ONP oNP = new ONP();
            oNP.Empleado = txtEmpleado.Text;
            oNP.Categoria = cbCategoria.Text;
            oNP.Basico = double.Parse(txtBasico.Text);
            oNP.Bonificacion = double.Parse(txtBonificacion.Text);
            txtRemuneracion.Text = oNP.Remuneracion().ToString();
            txtAportacion.Text = oNP.Descuento().ToString();
            txtNeto.Text = oNP.Neto().ToString();


        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(checkAFP.Checked)
            {
                Afp();

            }
            else
            {
                Onp();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            txtAportacion.Clear();
            txtBasico.Clear();
            txtBonificacion.Clear();
            txtNeto.Clear();
            txtRemuneracion.Clear();
            txtEmpleado.Focus();
        }
    }
}
