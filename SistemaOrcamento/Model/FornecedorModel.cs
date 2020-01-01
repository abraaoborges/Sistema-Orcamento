using SistemaOrcamento.Controller;
using SistemaOrcamento.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrcamento.Model
{
    public class FornecedorModel
    {
        FornecedorController controller = new FornecedorController();

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = controller.Listar();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Salvar(Fornecedores fornecedores)
        {
            try
            {
                controller.Inserir(fornecedores);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Editar(Fornecedores fornecedores)
        {
            try
            {
                controller.Editar(fornecedores);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Excluir(Fornecedores fornecedores)
        {
            try
            {
                controller.Excluir(fornecedores);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable Buscar(Fornecedores fornecedores)
        {
            try
            {
                return controller.Buscar(fornecedores);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
