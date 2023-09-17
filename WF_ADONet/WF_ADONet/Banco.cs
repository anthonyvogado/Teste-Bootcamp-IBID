using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_ADONet
{
    internal class Banco
    {
        private string stringConexao = "Data Source=localhost;Initial Catalog=banco1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }  
    }
}
