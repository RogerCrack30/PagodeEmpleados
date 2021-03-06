using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjCaso311
{
    public partial class frmPagoEmpleado : Form
    {
        public frmPagoEmpleado()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            string empleado = txtEmpleado.Text;
            int horas = int.Parse(txtHoras.Text);
            double costo = double.Parse(txtCosto.Text);

            double sueldoBasico = horas * costo;
            double bonificacion = 20.0 / 100 * sueldoBasico;
            double sueldoBruto = sueldoBasico + bonificacion;
            double descuento = sueldoBruto * 12.0 / 100;
            double sueldoNeto = sueldoBruto - descuento;

            lblMontoBruto.Text = sueldoBruto.ToString("C");
            lblMontoDescuento.Text = descuento.ToString("C");
            lblMontoNeto.Text = sueldoNeto.ToString("C");



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtEmpleado.Clear();
            txtHoras.Clear();
            txtCosto.Clear();
            lblMontoBruto.Text = "";
            lblMontoDescuento.Text = "";
            lblMontoNeto.Text = "";
            txtEmpleado.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Esta seguro de salir?",
                "control de pago",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) ;

            if (r == DialogResult.Yes)
                this.Close();

        }
    }
}
