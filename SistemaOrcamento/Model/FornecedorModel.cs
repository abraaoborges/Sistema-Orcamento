using SistemaOrcamento.Contoller;
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
            catch (Exception)
            {

                throw;
            }
        }

        public void Salvar(Fornecedores fornecedores)
        {
            try
            {
                controller.Inserir(fornecedores);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Editar(Fornecedores fornecedores)
        {
            try
            {
                controller.Editar(fornecedores);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Excluir(Fornecedores fornecedores)
        {
            try
            {
                controller.Excluir(fornecedores);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable Buscar(Fornecedores fornecedores)
        {
            try
            {
                return controller.Buscar(fornecedores);                
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
