using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Handson.Dao;
using Handson.Models;

namespace Handson.Business
{
    internal class LocaisBusiness
    {
        LocaisDao _LocaisDao = new LocaisDao();

        internal List<Locais> Listar_Locais()
        {
            List<Locais> list_locais = new List<Locais>();
            foreach (DataRow row in _LocaisDao.Listar_Locais().Rows)
            {
                list_locais.Add(new Locais
                {
                    ID = (int)row["ID"],
                    Descricao = row["Descricao"].ToString()
                });
            }

            return list_locais;
        }
    }
}