using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab1
{
    public partial class Form1 : Form
    {

        int nc = 0;

        void generarNumero()
        {
            nc++;
            txtNumGuia.Text = nc.ToString("0000");
        }

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generarNumero();
            txtNomCliente.Focus();
        }

        void Calcular()
        {
            //Instanciando la clase RegistrarTransporte
            RegistrarTransporte rt = new RegistrarTransporte();
     
            rt.NomCliente = txtNomCliente.Text;
            rt.Descrip = txtDescrip.Text;
            rt.TnMetricas = double.Parse(txtTnM.Text);
            rt.CostoTransporte();
            rt.Seguro();
            rt.Monto();
            rt.IGV();
            MessageBox.Show("Importe Total: s/."+ rt.ImporteTotal().ToString());
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Calcular();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            txtNomCliente.Clear();
            txtDescrip.Clear();
            txtNomCliente.Clear();
            txtTnM.Clear();
            generarNumero();
            txtNomCliente.Focus();
        }
    }
}
