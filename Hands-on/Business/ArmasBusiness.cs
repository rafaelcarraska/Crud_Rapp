using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Handson.Dao;
using Handson.Models;

namespace Handson.Business
{
    internal class ArmasBusiness
    {
        ArmasDao _ArmasDao = new ArmasDao();

        internal List<Armas> Listar_Armas()
        {
            List<Armas> list_armas = new List<Armas>();
            foreach (DataRow row in _ArmasDao.Listar_Armas().Rows)
            {
                list_armas.Add(new Armas
                {
                    ID = (int)row["ID"],
                    Descricao = row["Descricao"].ToString()
                });
            }

            return list_armas;
        }
    }
}