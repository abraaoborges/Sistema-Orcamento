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
    public class OrcamentoModel
    {
        OrcamentoController controller = new OrcamentoController();

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
        public DataTable ListarOrcamento()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = controller.ListarOrcamento();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Salvar(Orcamentos orcamentos)
        {
            try
            {
                controller.Inserir(orcamentos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Editar(Orcamentos orcamentos)
        {
            try
            {
                controller.Editar(orcamentos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Excluir(Orcamentos orcamentos)
        {
            try
            {
                controller.Excluir(orcamentos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable Buscar(Orcamentos orcamentos)
        {
            try
            {
                return controller.Buscar(orcamentos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
