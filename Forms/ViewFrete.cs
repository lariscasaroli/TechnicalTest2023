using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteTecnico2023.Model;

namespace TesteTecnico2023.Forms
{
    public partial class ViewFrete : Form
    {
        public ViewFrete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFrete_Click(object sender, EventArgs e)
        {

        }

        public void DefineFrete(double frete, string marca, string tipov, string modelo)
        {
            CultureInfo cultura = new CultureInfo("pt-BR");

            lblFrete.Text = frete.ToString("C", cultura);
            lblMarca.Text = marca.ToString();
            lblTipoVei.Text = tipov.ToString();
            lblModelo.Text = modelo.ToString();
        }
    }
}
