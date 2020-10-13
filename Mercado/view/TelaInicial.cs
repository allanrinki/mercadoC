using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class TelaInicial : Form
    {
        DateTime data_hora;
        public TelaInicial()
        {
            InitializeComponent();
            lbData.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            TelaVenda venda;
            venda = new TelaVenda();
            venda.Show();
            Hide();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {

            TelaProduto produto;
            produto = new TelaProduto();
            produto.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
          


        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lbHr.Text = data_hora.ToLongTimeString();
        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            lbHr.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
