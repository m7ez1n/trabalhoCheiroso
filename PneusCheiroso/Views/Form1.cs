using PneusCheiroso.Dominio;
using PneusCheiroso.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PneusCheiroso.Views
{
    public partial class Form1 : Form
    {
        Carro a;
        Conexao db = new Conexao();
        public Form1()
        {
            InitializeComponent();
            Envia.Click += Envia_Click;
        }

        private void Envia_Click(object sender, EventArgs e)
        {
            a = new Carro();
            a.Modelo = textNome.Text;

            db.Carros.Add(a);

            GridCarro.DataSource = db.Carros.ToList();
        }
    }
}
