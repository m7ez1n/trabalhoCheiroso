using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PneusCheiroso.Dominio;
using PneusCheiroso.Repositorio;
using PneusCheiroso.Services;

namespace PneusCheiroso
{
    public partial class InterfacePneus : Form
    {
        Services.Task calculos;
        Carro dadosCarro;
        Conexao db = new Conexao();
        public InterfacePneus()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

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

            GridCarros.DataSource = db.Carros.ToList();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            GridCarros.DataSource = db.Carros.Where(x => x.QuantidadePneu == 0).ToList();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            GridCarros.DataSource = db.Carros.Where(x => x.QuantidadePneu == 1).ToList();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            GridCarros.DataSource = db.Carros.Where(x => x.QuantidadePneu == 2).ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            GridCarros.DataSource = db.Carros.Where(x => x.QuantidadePneu == 3).ToList();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            GridCarros.DataSource = db.Carros.Where(x => x.QuantidadePneu == 4).ToList();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            calculos = new Services.Task();

            calculos.PrecoTotal(dadosCarro.QuantidadePneu, dadosCarro.PrecoUnitario);

            GridTotal.DataSource = db.total.ToList();
        }
    }
}
