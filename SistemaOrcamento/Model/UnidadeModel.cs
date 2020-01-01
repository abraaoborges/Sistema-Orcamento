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
    public class UnidadeModel
    {
        UnidadeController controller = new UnidadeController();

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
        public void Salvar(Unidades unidades)
        {
            try
            {
                controller.Inserir(unidades);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Editar(Unidades unidades)
        {
            try
            {
                controller.Editar(unidades);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Excluir(Unidades unidades)
        {
            try
            {
                controller.Excluir(unidades);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //public DataTable Buscar(Unidades unidades)
        //{
        //    try
        //    {
        //        return controller.Buscar(unidades);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
