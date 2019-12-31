using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrcamento
{
    public class Conexao
    {
        string conexao = "SERVER=localhost; DATABASE=orcamento; UID=root; PWD=;";
        
        public MySqlConnection con = null;

        public void AbrirConexao()
        {

        }

        public void FecharConexao()
        {

        }

    }
}
