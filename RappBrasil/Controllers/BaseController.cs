using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RappBrasil.Controllers
{
    public class BaseController : Controller
    {
        public bool IsNumeric(string temp)
        {
            try
            {
                Convert.ToDecimal(temp);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}