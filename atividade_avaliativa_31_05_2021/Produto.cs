using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace atividade_avaliativa_31_05_2021
{
    class Produto
    {
        string str_conexao = "Database=banco_teste; " +
                             "Data Source=localhost;" +
                             "User id=root;" +
                             "Password=root";
        string str_insert = "INSERT INTO produto(nome_produto, nome_fornecedor, qtd_produto, valor) VALUES(@nome_produto, @nome_fornecedor, @qtd_produto, @valor)";
        string str_select_all = "SELECT * FROM produto";
        string str_delete = "DELETE FROM produto WHERE id_produto = @id_produto";
        string str_update = "UPDATE produto SET nome_produto = @nome_produto, nome_fornecedor = @nome_fornecedor, qtd_produto = @qtd_produto, valor = @valor where id_produto = @id_produto";

        public void testar_conexao()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(str_conexao))
                {
                    conexao.Open();
                    Console.WriteLine("Conectado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falhou a conexão!");
                Console.WriteLine(ex);
            }
        }

        public void inserirDados(produtos produtos)
        {
            using (MySqlConnection conexao = new MySqlConnection(str_conexao))
            {
                using (MySqlCommand comando = new MySqlCommand(str_insert, conexao))
                {

                    comando.Parameters.AddWithValue("@nome_produto", produtos.nome_produto);
                    comando.Parameters.AddWithValue("@nome_fornecedor", produtos.nome_fornecedor);
                    comando.Parameters.AddWithValue("@qtd_produto", produtos.qtd_produto);
                    comando.Parameters.AddWithValue("@valor", produtos.valor);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                    conexao.Close();
                }
            }
        }

        public List<produtos> selecionarTodos()
        {
            List<produtos> produto = new List<produtos>();
            using (MySqlConnection conexao = new MySqlConnection(str_conexao))
            {
                using (MySqlCommand comando = new MySqlCommand(str_select_all, conexao))
                {
                    conexao.Open();
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        produtos produtos = new produtos();
                        produtos.id_produto = Convert.ToInt32(reader["id_produto"].ToString());
                        produtos.nome_produto = reader["nome_produto"].ToString();
                        produtos.nome_fornecedor = reader["nome_fornecedor"].ToString();
                        produtos.qtd_produto = Convert.ToInt32(reader["qtd_produto"].ToString());
                        produtos.valor = Convert.ToInt32(reader["valor"].ToString());
                        produto.Add(produtos);
                    }
                    conexao.Close();
                }
            }
            return produto;
        }

        public int delete(int id_produto)
        {
            int rows_affected = 0;
            using (MySqlConnection conexao = new MySqlConnection(str_conexao))
            {
                using (MySqlCommand comando = new MySqlCommand(str_delete, conexao))
                {
                    comando.Parameters.AddWithValue("@id_produto", id_produto);
                    conexao.Open();
                    rows_affected = comando.ExecuteNonQuery();
                    conexao.Close();
                }
            }
            return rows_affected;
        }
    }

}
