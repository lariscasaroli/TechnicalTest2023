namespace TesteTecnico2023.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TesteTecnico2023.Model;

    public partial class TravelAutonomyForm : Form
    {
        public TravelAutonomyForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double pesoCarga = Double.Parse(txtWeight.Text);
            double distancia = Double.Parse(txtDistance.Text);
            double qtdViagens;
            double litragemParcial;
            double litragemTotal;
            double frete = double.MaxValue;
            Vehicle veiculo = null;
            foreach (var vehicle in Data.VEHICLES)
            {
                //pesocarga/ capveiculo = viagn
                qtdViagens = pesoCarga / vehicle.WeightSupported;
                //(kmdistan*autoLi)/(kmauto*x) = LiVi
                litragemParcial = distancia / vehicle.Autonomy;

                litragemTotal = litragemParcial * qtdViagens;

                double tempFrete = litragemTotal * Data.FUEL_PRICES.Find(fuel => fuel.name == vehicle.FuelType).price;

                    if (tempFrete < frete)
                    {
                    frete = tempFrete;
                    veiculo = vehicle;
                    }
            }
            ViewFrete tela = new ViewFrete();
            tela.DefineFrete(frete, veiculo.Brand, veiculo.Type(), veiculo.ModelName);
            tela.Show();
        }
    }
}
