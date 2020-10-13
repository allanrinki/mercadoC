using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Mercado
{
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            exibirDados();
        }

        private void exibirDados()
        {
            try
            {
                Produtos produto = new Produtos();
                DataTable Dt = produto.get();
                dgvProdutos.DataSource = Dt.DefaultView;
            }
            catch
            {
                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pega a coleção que contém todas as linhas
                DataGridViewRow row = this.dgvProdutos.Rows[e.RowIndex];
                //preenche os textbox com os valores
                txtId.Text = row.Cells[0].Value.ToString();
                txtProduto.Text = row.Cells[1].Value.ToString();
                txtPreco.Text = row.Cells[2].Value.ToString();
                txtQuantidade.Text = row.Cells[3].Value.ToString();                
                rtxObser.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnInserirProd_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtProduto.Text.Equals("") || txtQuantidade.Text.Equals("") || txtPreco.Text.Equals(""))
                {
                    MessageBox.Show("Informe os dados necessários.", "NOVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Produtos produto = new Produtos();
                produto.NomeProduto = txtProduto.Text;
                produto.PrecoProduto = double.Parse(txtPreco.Text);
                produto.QuantidadeProduto = int.Parse(txtQuantidade.Text);
                produto.DescricaoProduto = rtxObser.Text;
                produto.insertProduto();

                MessageBox.Show("Produto Cadastrado com Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                txtPreco.Clear();
                txtProduto.Clear();
                txtQuantidade.Clear();
                rtxObser.Clear();
                exibirDados();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaInicial inicio;
            inicio = new TelaInicial();
            inicio.Show();
            Hide();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {

            if (txtProduto.Text.Equals("") || txtQuantidade.Text.Equals("") || txtPreco.Text.Equals(""))
            {
                MessageBox.Show("Os dados necessários não foram informados.", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }                    


            try
            {
                
                Produtos produto = new Produtos();
                int Codigo = Convert.ToInt32(txtId.Text);
                produto.NomeProduto = txtProduto.Text;
                produto.PrecoProduto = double.Parse(txtPreco.Text);
                produto.QuantidadeProduto = int.Parse(txtQuantidade.Text);
                produto.DescricaoProduto = rtxObser.Text;
                produto.editarProduto(Codigo);

                MessageBox.Show("Produto Alterado com Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                txtPreco.Clear();
                txtProduto.Clear();
                txtQuantidade.Clear();
                rtxObser.Clear();

            }

        }

        private void TelaProduto_Load(object sender, EventArgs e)
        {
           
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este produto ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    Produtos produto = new Produtos();
                    int Codigo = Convert.ToInt32(txtId.Text);
                    produto.NomeProduto = txtProduto.Text;
                    produto.PrecoProduto = double.Parse(txtPreco.Text);
                    produto.QuantidadeProduto = int.Parse(txtQuantidade.Text);
                    produto.DescricaoProduto = rtxObser.Text;

                    produto.Delete(Codigo);

                    MessageBox.Show("O Produto foi excluído do cadastro.");
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                txtId.Clear();
                txtPreco.Clear();
                txtProduto.Clear();
                txtQuantidade.Clear();
                rtxObser.Clear();

                exibirDados();
            }
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            txtId.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtPreco.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();
            rtxObser.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            TelaVenda venda;
            venda = new TelaVenda();
            venda.Show();
            Hide();
        }
    }
    
}
