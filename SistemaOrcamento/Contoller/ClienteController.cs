using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaOrcamento.Entities;
using System.Data;
using System.Windows.Forms;

namespace SistemaOrcamento.Contoller
{
    public class ClienteController
    {
        MySqlCommand sql;
        Conexao con = new Conexao();

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM clientes order by id_cliente desc", con.con);
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
        public void Editar(Clientes clientes)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE clientes SET nome = @nome, telefone = @telefone, email = @email WHERE id_cliente = @id", con.con);
                sql.Parameters.AddWithValue("@nome", clientes.Nome);
                sql.Parameters.AddWithValue("@telefone", clientes.Telefone);
                sql.Parameters.AddWithValue("@email", clientes.Email);
                sql.Parameters.AddWithValue("@id", clientes.IdCliente);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex.Message);
                con.FecharConexao();
            }
        }
        public DataTable Buscar(Clientes clientes)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM clientes WHERE nome like @nome", con.con);
                sql.Parameters.AddWithValue("@nome", clientes.Nome + "%");
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
        public void Excluir(Clientes clientes)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM clientes WHERE id_cliente = @id", con.con);
                sql.Parameters.AddWithValue("@id", clientes.IdCliente);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir " + ex.Message);
                con.FecharConexao();
            }
        }
        public void Inserir(Clientes clientes)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO clientes (nome, telefone, email) values (@nome, @telefone, @email)", con.con);
                sql.Parameters.AddWithValue("@nome", clientes.Nome);
                sql.Parameters.AddWithValue("@telefone", clientes.Telefone);
                sql.Parameters.AddWithValue("@email", clientes.Email);
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
