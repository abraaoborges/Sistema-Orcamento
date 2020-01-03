using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaOrcamento.Entities;
using System.Data;
using System.Windows.Forms;

namespace SistemaOrcamento.Controller
{
    public class ProdutoController
    {
        MySqlCommand sql;
        Conexao con = new Conexao();

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT prod.id_produto, prod.codigo, forn.nome, prod.nome, prod.descricao, unid.unidade, prod.valor " +
                                        "FROM produtos prod " +
                                        "INNER JOIN fornecedores forn on (forn.id_fornecedor = prod.id_fornecedor) " +
                                        "INNER JOIN unidades unid on (unid.id_unidade = prod.id_unidade) " +
                                        "order by prod.nome asc", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("Erro ao Listar " + ex.Message);
                con.FecharConexao();
            }
        }
        public DataTable ListarProdutos()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM produtos order by nome desc", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("Erro ao Listar " + ex.Message);
                con.FecharConexao();
            }
        }
        public void Editar(Produtos produtos)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE produtos SET codigo = @codigo, id_fornecedor = @id_fornecedor, nome = @nome, descricao = @descricao, id_unidade = @id_unidade, valor = @valor WHERE id_produto = @id", con.con);
                sql.Parameters.AddWithValue("@codigo", produtos.Codigo);
                sql.Parameters.AddWithValue("@id_fornecedor", produtos.IdFornecedor);
                sql.Parameters.AddWithValue("@nome", produtos.Nome);
                sql.Parameters.AddWithValue("@descricao", produtos.Descricao);
                sql.Parameters.AddWithValue("@id_unidade", produtos.IdUnidade);
                sql.Parameters.AddWithValue("@valor", produtos.Valor);
                sql.Parameters.AddWithValue("@id", produtos.IdProduto);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex.Message);
                con.FecharConexao();
            }
        }
        public DataTable Buscar(Produtos produtos)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM produtos WHERE nome like @nome or codigo like @codigo", con.con);
                sql.Parameters.AddWithValue("@nome", produtos.Nome + "%");
                sql.Parameters.AddWithValue("@codigo", produtos.Codigo + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("Erro ao Buscar " + ex.Message);
                con.FecharConexao();
            }
        }
        public DataTable BuscarValor(Produtos produtos)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT valor FROM produtos WHERE id_produto = @id", con.con);
                sql.Parameters.AddWithValue("@id", produtos.IdProduto);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("Erro ao Buscar " + ex.Message);
                con.FecharConexao();
            }
        }
        public void Excluir(Produtos produtos)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM produtos WHERE id_produto = @id", con.con);
                sql.Parameters.AddWithValue("@id", produtos.IdProduto);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir " + ex.Message);
                con.FecharConexao();
            }
        }
        public void Inserir(Produtos produtos)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO produtos (codigo, id_fornecedor, nome, descricao, id_unidade, valor) values (@codigo, @id_fornecedor, @nome, @descricao, @id_unidade, @valor)", con.con);
                sql.Parameters.AddWithValue("@codigo", produtos.Codigo);
                sql.Parameters.AddWithValue("@id_fornecedor", produtos.IdFornecedor);
                sql.Parameters.AddWithValue("@nome", produtos.Nome);
                sql.Parameters.AddWithValue("@descricao", produtos.Descricao);
                sql.Parameters.AddWithValue("@id_unidade", produtos.IdUnidade);
                sql.Parameters.AddWithValue("@valor", produtos.Valor);
                sql.Parameters.AddWithValue("@id", produtos.IdProduto);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar " + ex.Message);
                con.FecharConexao();
            }
        }
    }
}
