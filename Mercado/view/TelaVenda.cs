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
using System.Data;

namespace Mercado
{
    public partial class TelaVenda : Form
    {


        public TelaVenda()
        {
            InitializeComponent();            
        }

        private void TelaVenda_Load(object sender, EventArgs e)
        {
            
            lbData.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);
            
        }

        private void exibirDados()
        {
            try
            {
                Produtos produto = new Produtos();
                DataTable Dt = produto.get();
                dgvProd.DataSource = Dt.DefaultView;
            }
            catch
            {
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaProduto produto;
            produto = new TelaProduto();
            produto.Show();
            Hide();
        }

        private void txtTotalVenda_TextChanged(object sender, EventArgs e)
        {
            txtTotalVenda.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //se estiver vazio avisa
            if (txtProcurar.Text == "")
            {
                MessageBox.Show("Informe o ID do colaborador que você quer procurar...");
            }
            else
            {
                int codigo = Convert.ToInt32(txtProcurar.Text);

                DataTable dt = Vendas.Procurar(codigo);
                if (dt.Rows[0].Table.Rows.Count > 0)
                {
                    dgvProd.DataSource = dt.DefaultView;
                    dgvProd.Refresh();
                    dgvProd.Update();
                }
                else
                {

                    MessageBox.Show("Informação não localizada...");
                    exibirDados();
                }
            }
        }

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pega a coleção que contém todas as linhas
                DataGridViewRow row = this.dgvProd.Rows[e.RowIndex];
                //preenche os textbox com os valores
                txtId.Text = row.Cells[0].Value.ToString();
                txtProdVenda.Text = row.Cells[1].Value.ToString();
                txtPrecovenda.Text = row.Cells[2].Value.ToString();
                txtQuantVenda.Text = "1";

            }
        }

        private void txtQuantVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserirProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProdVenda.Text.Equals("") || txtQuantVenda.Text.Equals("") || txtPrecovenda.Text.Equals(""))
                {
                    MessageBox.Show("Informe os dados necessários.", "NOVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // array de string com os dados informados

                Vendas produto = new Vendas();
                produto.NomeProduto = txtProdVenda.Text;
                produto.PrecoProduto = double.Parse(txtPrecovenda.Text);
                produto.QuantidadeProduto = int.Parse(txtQuantVenda.Text);
                double PrecoTotal = produto.PrecoProduto * produto.QuantidadeProduto;

                string[] dados = { txtId.Text, txtProdVenda.Text, txtQuantVenda.Text, PrecoTotal.ToString() };

                // preenche o datagridview com os dados informados
                // cada possição do array de string corresponde a uma
                // coluna do nosso datagridview

                this.dgvItensVenda.Rows.Add(dados);

                txtTotalVenda.Text = dgvItensVenda.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[Preco.Name].Value ?? 0)).ToString("##.00");

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                txtId.Clear();
                txtProdVenda.Clear();
                txtPrecovenda.Clear();
                txtQuantVenda.Clear();

            }

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                
                Vendas produto = new Vendas();
                int ultimoID = produto.InserirVenda(DateTime.Parse(lbData.Text), double.Parse(txtTotalVenda.Text));
                lbid.Text = ultimoID.ToString();

                string conectaBanco = "SERVER=localhost; DATABASE=bd_mercado; UID=root; PWD=root";

                MySqlConnection conexao = null;
                MySqlCommand comando;


                String sql = "INSERT INTO itens_venda (id_produto, id_venda, quantidade_itens) " +
                          "VALUES (@idProd, @ultimoID, @quant)";
                conexao = new MySqlConnection(conectaBanco);
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                //abro a conexão
                conexao.Open();

                //percorro o DataGridView
                for (int i = 0; i < dgvItensVenda.Rows.Count - 1; i++)
                {
                    //limpo os parâmetros
                    cmd.Parameters.Clear();
                    //crio os parâmetro do comando
                    //e passo as linhas do dgvClientes para eles
                    //onde a célula indica a coluna do dgv
                    cmd.Parameters.AddWithValue("@idProd",
                        dgvItensVenda.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@quant",
                        dgvItensVenda.Rows[i].Cells[2].Value);
                    //executo o comando
                    cmd.Parameters.AddWithValue("@ultimoID", ultimoID);
                    cmd.ExecuteNonQuery();
                }
                //Fecho conexão
                conexao.Close();
            

                MessageBox.Show("Venda Realizada com Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                TelaVenda venda;
                venda = new TelaVenda();
                venda.Show();
                Hide();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaInicial inicio;
            inicio = new TelaInicial();
            inicio.Show();
            Hide();
        }
    }

        
}


