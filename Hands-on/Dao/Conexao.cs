using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Handson.Dao
{
    internal class Conexao
    {
        private SqlConnection _connck;

        internal Conexao()
        {
            if (_connck == null)
            {
                _connck = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=Handson;User ID=SEU_USUARIO;Password=SUA_SENHA");
            }
        }

        internal Conexao(string strConn)
        {
            if (_connck == null)
            {
                _connck = new SqlConnection(strConn);
            }
        }

        internal void open()
        {
            if (_connck.State == ConnectionState.Closed)
            {
                _connck.Open();
                using (SqlCommand cmd = new SqlCommand("SET DATEFORMAT mdy", _connck))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void close()
        {
            if (_connck.State.Equals(ConnectionState.Open))
                _connck.Close();
        }

        internal virtual DataTable dataTable(string sql)
        {
            this.open();
            using (SqlCommand cmd = new SqlCommand(sql, _connck))
            {
                cmd.CommandTimeout = 0;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tb = new DataTable("TEMP");
                    adapter.Fill(tb);
                    this.close();
                    return tb;
                }
            }

        }
    }

}