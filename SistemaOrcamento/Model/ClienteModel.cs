using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaOrcamento.Contoller;
using SistemaOrcamento.Entities;
using System.Data;


namespace SistemaOrcamento.Model
{
    class ClienteModel
    {
        ClienteController controller = new ClienteController();

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
        public void Salvar(Clientes clientes)
        {
            try
            {
                controller.Inserir(clientes);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Editar(Clientes clientes)
        {
            try
            {
                controller.Editar(clientes);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Excluir(Clientes clientes)
        {
            try
            {
                controller.Excluir(clientes);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable Buscar(Clientes clientes)
        {
            try
            {
                return controller.Buscar(clientes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
