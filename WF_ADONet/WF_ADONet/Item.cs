using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_ADONet
{
    internal class Item
    {
        public int id;
        public string nome;


        public bool adicionar()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into itens " +
                " values (@nome);";

            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);

            command.Parameters[0].Value = nome;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool remover()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction trans = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = trans;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from itens where id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = id;

            try
            {
                int linhasAfetadas = command.ExecuteNonQuery();
                if(linhasAfetadas != 0) { 
                trans.Commit();
                return true;
                }
                else {
                    throw new Exception("ID não existente");
                }
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool editar()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update itens set nome = @nome" +
            " where id = @id";
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = id;

            try
            {
                int linhasAfetadas = cmd.ExecuteNonQuery();
                if (linhasAfetadas != 0)
                {
                    tran.Commit();
                    return true;
                }
                else
                {
                    throw new Exception("ID não existente");
                }
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public DataTable retornaTodosOsItens()
        {
            Banco bd = new Banco();
            try
            {
                SqlConnection cn = bd.abrirConexao();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from itens";
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                bd.fecharConexao();
            }
        }



    }
}
