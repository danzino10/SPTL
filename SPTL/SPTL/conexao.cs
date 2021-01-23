using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SPTL
{
    class Conexao
    {
        string conexao_string = @"Data Source=DANZ\SQLEXPRESS;Initial Catalog=Express;Integrated Security=True";
        SqlConnection conn;

        public Conexao()
        {
            conn = new SqlConnection(conexao_string);
        }

        public void abrir()
        {
            conn.Open();
        }
        public void fechar()
        {
            conn.Close();
        }

        public SqlConnection SaberConexao()
        {
            return conn;
        }
    }
}
