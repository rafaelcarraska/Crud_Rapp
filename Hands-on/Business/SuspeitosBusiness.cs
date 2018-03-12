using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Handson.Dao;
using Handson.Models;

namespace Handson.Business
{
    internal class SuspeitosBusiness
    {
       SuspeitosDao _SuspeitosDao = new SuspeitosDao();

        internal List<Suspeitos> Listar_Suspeitos()
        {
            List<Suspeitos> list_suspeitos = new List<Suspeitos>();
            foreach (DataRow row in _SuspeitosDao.Listar_Suspeitos().Rows)
            {
                list_suspeitos.Add(new Suspeitos
                {
                    ID = (int)row["ID"],
                    Descricao = row["Descricao"].ToString()
                });
            }

            return list_suspeitos;
        }
    }
}