using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using RappBrasil.Models;
using System.Data;
using System.Text;
using System.Configuration;
using System.Security.Cryptography;

namespace RappBrasil.Dao
{
    public class UsuarioDao
    {
        Conexao _conn = new Conexao();
        public List<Usuario> Listar_Usuarios()
        {
            List<Usuario> list_usuarios = new List<Usuario>();

            DataTable dt_usuarios = _conn.dataTable("select * from usuarios", "USUARIOS");
            foreach (DataRow row in dt_usuarios.Rows)
            {
                list_usuarios.Add(new Usuario
                {
                    Cod_Usuario = Convert.ToInt32(row["cod_usuario"].ToString()),
                    Nome = row["Nome"].ToString(),
                    Email = row["Email"].ToString(),
                    Telefone = row["Telefone"].ToString(),
                    Empresa = row["Empresa"].ToString()
                });
            }
            return list_usuarios;
        }


        public string Insert(Usuario usuario)
        {
            string msg = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(usuario.Telefone))
                    usuario.Telefone = "";

                string strInsert = "insert into usuarios (nome, Email, Telefone, Empresa) values('"
                    + usuario.Nome.Replace("'", "''") + "', '"
                    + usuario.Email.Replace("'", "''") + "', '"
                    + usuario.Telefone.Replace("'", "''") + "', '"
                    + usuario.Empresa.Replace("'","''") + "'); SELECT SCOPE_IDENTITY();";
                    int identity = Convert.ToInt32(_conn.scalar(strInsert));
                    msg = identity.ToString();
            }
            catch (Exception)
            {
                msg = "Erro ao adicionar o usuário " + usuario.Nome + ".";
            }
            return msg;
        }

        public string update(Usuario usuario)
        {
            string msg = string.Empty;
            try
            {
                string strupdate = "update usuarios set Nome = '" + usuario.Nome.Replace("'", "''")
                + "', Email = '" + usuario.Email.Replace("'", "''")                
                + "', Telefone = '" + usuario.Telefone.Replace("'", "''")
                + "', Empresa = '" + usuario.Empresa.Replace("'", "''") + "' "
                +" where Cod_Usuario = "+usuario.Cod_Usuario;
               
                _conn.execute(strupdate);                
            }
            catch (Exception)
            {
                msg = "Erro ao Editar o usuário " + usuario.Nome + ".";
            }
            return msg;
        }
        

        public string delete(int cod_usuario)
        {
            string msg = "";
            try
            {
                string strdelete = "delete from usuarios where cod_usuario = " + cod_usuario + "";
                _conn.execute(strdelete);
            }
            catch (Exception)
            {
                msg = "Erro ao deletar o usuário.";
            }
            return msg;
        }


    }
}
