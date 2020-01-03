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
    public class OrcamentoController
    {
        MySqlCommand sql;
        Conexao con = new Conexao();

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM orcamentos order by data desc", con.con);
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
        public DataTable ListarOrcamento()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT " +
                    "orc.id_orcamento, orc.numero_orcamento, pro.nome, pro.valor, cli.nome, orc.quantidade, orc.valor_total, orc.data, orc.id_produto, orc.id_cliente " +
                    "FROM orcamentos orc " +
                    "INNER JOIN produtos pro on (pro.id_produto = orc.id_produto) " +
                    "INNER JOIN clientes cli on (cli.id_cliente = orc.id_cliente) " +
                    "order by id_orcamento desc", con.con);
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
        public void Editar(Orcamentos orcamentos)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE orcamentos " +
                                        "SET numero_orcamento = @numero_orcamento, id_produto = @id_produto, id_cliente = @id_cliente, quantidade = @quantidade, valor_total = @valor_total, data = @data " +
                                        "WHERE id_orcamento = @id", con.con);
                sql.Parameters.AddWithValue("@numero_orcamento", orcamentos.NumOrcamento);
                sql.Parameters.AddWithValue("@id_produto", orcamentos.IdProduto);
                sql.Parameters.AddWithValue("@id_cliente", orcamentos.IdCliente);
                sql.Parameters.AddWithValue("@quantidade", orcamentos.Quantidade);
                sql.Parameters.AddWithValue("@valor_total", orcamentos.ValorTotal);
                sql.Parameters.AddWithValue("@data", orcamentos.Data);
                sql.Parameters.AddWithValue("@id", orcamentos.IdOrcamento);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex.Message);
                con.FecharConexao();
            }
        }
        public DataTable Buscar(Orcamentos orcamentos)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT " +
                    "orc.id_orcamento, orc.numero_orcamento, pro.nome, pro.valor, cli.nome, orc.quantidade, orc.valor_total, orc.data, orc.id_produto, orc.id_cliente " +
                    "FROM orcamentos orc " +
                    "INNER JOIN produtos pro on (pro.id_produto = orc.id_produto) " +
                    "INNER JOIN clientes cli on (cli.id_cliente = orc.id_cliente) " +
                    "WHERE orc.numero_orcamento = @numero_orcamento or orc.id_cliente = @id_cliente or orc.data = @data", con.con);
                sql.Parameters.AddWithValue("@numero_orcamento", orcamentos.NumOrcamento);
                sql.Parameters.AddWithValue("@id_cliente", orcamentos.IdCliente);
                sql.Parameters.AddWithValue("@data", orcamentos.Data);
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
        public void Excluir(Orcamentos orcamentos)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM orcamentos " +
                                        "WHERE id_orcamento = @id", con.con);
                sql.Parameters.AddWithValue("@id", orcamentos.IdOrcamento);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir " + ex.Message);
                con.FecharConexao();
            }
        }
        public void Inserir(Orcamentos orcamentos)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO orcamentos " +
                                        "(numero_orcamento, id_produto, id_cliente, quantidade, valor_total, data) " +
                                        "values " +
                                        "(@numero_orcamento, @id_produto, @id_cliente, @quantidade, @valor_total, @data)", con.con);
                sql.Parameters.AddWithValue("@numero_orcamento", orcamentos.NumOrcamento);
                sql.Parameters.AddWithValue("@id_produto", orcamentos.IdProduto);
                sql.Parameters.AddWithValue("@id_cliente", orcamentos.IdCliente);
                sql.Parameters.AddWithValue("@quantidade", orcamentos.Quantidade);
                sql.Parameters.AddWithValue("@valor_total", orcamentos.ValorTotal);
                sql.Parameters.AddWithValue("@data", orcamentos.Data);
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
