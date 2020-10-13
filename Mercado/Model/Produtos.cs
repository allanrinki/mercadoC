using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Mercado
{
    class Produtos
    {
        public int Codigo;
        public string NomeProduto;
        public double PrecoProduto;
        public int QuantidadeProduto;
        public string DescricaoProduto;

        string conectaBanco = "SERVER=localhost; DATABASE=bd_mercado; UID=root; PWD=root";

        MySqlConnection conexao = null;
        MySqlCommand comando;



        public DataTable get()
        {
            conexao = new MySqlConnection(conectaBanco);
            comando = new MySqlCommand("SELECT id_produto AS Codigo, nome_produto AS Produto, preco_produto AS Preco, quantidade_estoque AS Quantidade, descricao_produto AS Descricao, status_produto AS Status  FROM cadastro_produtos", conexao);

            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = comando;

            DataTable Dt = new DataTable();
            Da.Fill(Dt);

            return Dt;
        }


        public void insertProduto()
        {
            try
            {

                String sql = "INSERT INTO cadastro_produtos (nome_produto,preco_produto,descricao_produto,quantidade_estoque) VALUES (@nome,@preco,@descricao,@quantidade)";
                conexao = new MySqlConnection(conectaBanco);
                MySqlCommand cmd = new MySqlCommand(sql, conexao);                
                cmd.Parameters.AddWithValue("@nome", NomeProduto);
                cmd.Parameters.AddWithValue("@preco", PrecoProduto);
                cmd.Parameters.AddWithValue("@descricao", DescricaoProduto);
                cmd.Parameters.AddWithValue("@quantidade", QuantidadeProduto);
                conexao.Open();
                cmd.ExecuteNonQuery();


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

        public void editarProduto(int Codigo)
        {
            String sql = "UPDATE cadastro_produtos set nome_produto = @nome ,preco_produto = @preco ,descricao_produto = @descricao,quantidade_estoque = @quantidade WHERE id_produto = @idproduto";
            conexao = new MySqlConnection(conectaBanco);
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idproduto", Codigo);
            cmd.Parameters.AddWithValue("@nome", NomeProduto);
            cmd.Parameters.AddWithValue("@preco", PrecoProduto);
            cmd.Parameters.AddWithValue("@descricao", DescricaoProduto);
            cmd.Parameters.AddWithValue("@quantidade", QuantidadeProduto);
            conexao.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int Codigo)
        {
            String sql = "DELETE FROM cadastro_produtos WHERE id_produto = "+ Codigo;
            conexao = new MySqlConnection(conectaBanco);
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            
            conexao.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
