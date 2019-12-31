﻿using MySql.Data.MySqlClient;
using SistemaOrcamento.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento.Contoller
{
    public class FornecedorController
    {
        MySqlCommand sql;
        Conexao con = new Conexao();

        public DataTable Listar()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM fornecedores order by id_fornecedor desc", con.con);
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
        public void Editar(Fornecedores fornecedores)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE fornecedores SET cnpj = @cnpj, nome = @nome, telefone = @telefone, endereco = @endereco WHERE id_fornecedor = @id", con.con);
                sql.Parameters.AddWithValue("@cnpj", fornecedores.Cnpj);
                sql.Parameters.AddWithValue("@nome", fornecedores.Nome);
                sql.Parameters.AddWithValue("@telefone", fornecedores.Telefone);
                sql.Parameters.AddWithValue("@endereco", fornecedores.Endereco);
                sql.Parameters.AddWithValue("@id", fornecedores.IdForncedor);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex.Message);
                con.FecharConexao();
            }
        }

        public DataTable Buscar(Fornecedores fornecedores)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM fornecedores WHERE nome like @nome or cnpj like @cnpj", con.con);
                sql.Parameters.AddWithValue("@cnpj", fornecedores.Cnpj + "%");
                sql.Parameters.AddWithValue("@nome", fornecedores.Nome + "%");
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
        public void Excluir(Fornecedores fornecedores)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM fornecedores WHERE id_fornecedor = @id", con.con);
                sql.Parameters.AddWithValue("@id", fornecedores.IdForncedor);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir " + ex.Message);
                con.FecharConexao();
            }
        }
        public void Inserir(Fornecedores fornecedores)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO fornecedores (cnpj, nome, telefone, endereco) values (@cnpj, @nome, @telefone, @endereco)", con.con);
                sql.Parameters.AddWithValue("@cnpj", fornecedores.Cnpj);
                sql.Parameters.AddWithValue("@nome", fornecedores.Nome);
                sql.Parameters.AddWithValue("@telefone", fornecedores.Telefone);
                sql.Parameters.AddWithValue("@endereco", fornecedores.Endereco);
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
