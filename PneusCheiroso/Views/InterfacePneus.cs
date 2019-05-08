using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PneusCheiroso.Dominio;
using PneusCheiroso.Repositorio;

namespace PneusCheiroso
{
    public partial class InterfacePneus : Form
    {
        List<Carro> quantT = new List<Carro>();
        Carro dadosCarro;
        Conexao db = new Conexao();
        public InterfacePneus()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            InterfacePneus.ActiveForm.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dadosCarro = new Carro();
            dadosCarro.Modelo = textModelo.Text;
            dadosCarro.QuantidadeCarros = int.Parse(textQuantidade.Text);
            dadosCarro.QuantidadePneu = int.Parse(textQtdPneus.Text);
            dadosCarro.PrecoUnitario = double.Parse(textPreco.Text);
            
            db.Carros.Add(dadosCarro);
            quantT = db.Carros.ToList();
            GridCarros.DataSource = quantT;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            quantT = db.Carros.Where(x => x.QuantidadePneu == 0).ToList();
            GridCarros.DataSource = quantT;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            quantT = db.Carros.Where(x => x.QuantidadePneu == 1).ToList();
            GridCarros.DataSource = quantT;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            quantT = db.Carros.Where(x => x.QuantidadePneu == 2).ToList();
            GridCarros.DataSource = quantT;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            quantT = db.Carros.Where(x => x.QuantidadePneu == 3).ToList();
            GridCarros.DataSource = quantT;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            quantT = db.Carros.Where(x => x.QuantidadePneu == 4).ToList();
            GridCarros.DataSource = quantT;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //lb_valorTotal.Text = "Valor Total: ";
            //lb_valorTotal.Text += "R$ " + ValorTotal().ToString();

            string message = "O preço total dos pneus foi: R$ " + ValorTotal().ToString(CultureInfo.InvariantCulture);
            string title = "Preço Total:";

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private double ValorTotal()
        {
            double total=0.0;

            foreach(var i in quantT)
            {
                total += i.QuantidadeCarros * i.QuantidadePneu * i.PrecoUnitario;
            }
            return total;
        }

        private int TotalPneus()
        {
            int total = 0;

            foreach (var i in quantT)
            {
                total += i.QuantidadeCarros * i.QuantidadePneu;
            }

            return total;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string message = "O total de pneus trocados em toda a frota foi de: " + TotalPneus().ToString(CultureInfo.InvariantCulture);
            string title = "Número total de pneus";

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            quantT = db.Carros.ToList();
            GridCarros.DataSource = quantT;
        }
    }
}
