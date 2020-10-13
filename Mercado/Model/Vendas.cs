using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Mercado
{
    class Vendas
    {
        public int Codigo;
        public string NomeProduto;
        public double PrecoProduto;
        public int QuantidadeProduto;
        public string DescricaoProduto;
        public DateTime Data;
        public double valor_total;




        string conectaBanco = "SERVER=localhost; DATABASE=bd_mercado; UID=root; PWD=root";

        MySqlConnection conexao = null;
        MySqlCommand comando;

       

        public static DataTable Procurar(int codigo)
        {

            string conectaBanco = "SERVER=localhost; DATABASE=bd_mercado; UID=root; PWD=root";

            MySqlConnection conexao = null;
            MySqlCommand comando;

            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT id_produto AS Codigo, nome_produto AS Produto, preco_produto AS Preco, quantidade_estoque AS Quantidade, descricao_produto AS Descricao, status_produto AS Status  FROM cadastro_produtos WHERE id_produto = " + codigo, conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = comando;

                DataTable Dt = new DataTable();
                Da.Fill(Dt);

                return Dt;
            }
            catch
            {
                throw;
            }
        }

       

        public int InserirVenda(DateTime _Data, Double _valor_total)
        {
            try
            {
                String sql = "INSERT INTO vendas (data_venda, valor_total_venda) VALUES (@data,@valor_total)";
                conexao = new MySqlConnection(conectaBanco);
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@data", _Data);
                cmd.Parameters.AddWithValue("@valor_total", _valor_total);
                conexao.Open();
                cmd.ExecuteNonQuery();


                // Verifica se existe um ultimo id inserido e adiciona um
                // parametro para tratá-lo
                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));

                // Retorna o id do novo rgistro e convert de Int64 para Int32 (int).
                return Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }


    }
}


