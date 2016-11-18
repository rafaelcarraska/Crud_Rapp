using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RappBrasil.Models;
using RappBrasil.Dao;
using System.Web.Script.Serialization;

namespace RappBrasil.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            UsuarioDao usuariodao = new UsuarioDao();
            List<Usuario> listUsuarios = usuariodao.Listar_Usuarios();
            return View(listUsuarios);
        }

        public string Save(Usuario usuario)
        {
            UsuarioDao usuariodao = new UsuarioDao();
            string msg = string.Empty;
            string cod_usuario = string.Empty;

            if (usuario.Cod_Usuario.Equals(0))
            {
                cod_usuario = usuariodao.Insert(usuario);
                if (IsNumeric(cod_usuario))
                    usuario.Cod_Usuario = Convert.ToInt32(cod_usuario);
                else
                    msg = cod_usuario;
            }
            else
                msg = usuariodao.update(usuario);

            string json = "[{";
            json += "\"Usuario\":" + new JavaScriptSerializer().Serialize(usuario) + ", ";
            json += "\"messg\":" + new JavaScriptSerializer().Serialize(msg) + "}]";

            return json;
        }

        public ActionResult Delete(int Cod_Usuario)
        {
            UsuarioDao usuariodao = new UsuarioDao();
            string msg = string.Empty;
            msg = usuariodao.delete(Cod_Usuario);
            return Json(msg);
        }
    }
}