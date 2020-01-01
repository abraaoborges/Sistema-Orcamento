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
    public class UnidadeController
    {
        MySqlCommand sql;
        Conexao con = new Conexao();

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM unidades order by unidade asc", con.con);
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
        public void Editar(Unidades unidades)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE unidades SET unidade = @unidade WHERE id_unidade = @id", con.con);
                sql.Parameters.AddWithValue("@unidade", unidades.unidade);
                sql.Parameters.AddWithValue("@id", unidades.IdUnidade);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex.Message);
                con.FecharConexao();
            }
        }
        //public DataTable Buscar(Unidades unidades)
        //{
        //    try
        //    {
        //        con.AbrirConexao();
        //        sql = new MySqlCommand("SELECT * FROM unidades WHERE unidade like @unidades", con.con);
        //        sql.Parameters.AddWithValue("@unidades", unidades.unidade + "%");
        //        MySqlDataAdapter da = new MySqlDataAdapter();
        //        da.SelectCommand = sql;
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //        //MessageBox.Show("Erro ao Buscar " + ex.Message);
        //        con.FecharConexao();
        //    }
        //}
        public void Excluir(Unidades unidades)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM unidades WHERE id_unidade = @id", con.con);
                sql.Parameters.AddWithValue("@id", unidades.IdUnidade);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir " + ex.Message);
                con.FecharConexao();
            }
        }
        public void Inserir(Unidades unidades)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO unidades (unidade) values (@unidade)", con.con);
                sql.Parameters.AddWithValue("@unidade", unidades.unidade);
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
