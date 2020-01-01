using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaOrcamento.Controller;
using SistemaOrcamento.Entities;
using System.Data;

namespace SistemaOrcamento.Model
{
    public class ProdutoModel
    {
        ProdutoController controller = new ProdutoController();

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
        public void Salvar(Produtos produtos)
        {
            try
            {
                controller.Inserir(produtos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Editar(Produtos produtos)
        {
            try
            {
                controller.Editar(produtos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Excluir(Produtos produtos)
        {
            try
            {
                controller.Excluir(produtos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable Buscar(Produtos produtos)
        {
            try
            {
                return controller.Buscar(produtos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
