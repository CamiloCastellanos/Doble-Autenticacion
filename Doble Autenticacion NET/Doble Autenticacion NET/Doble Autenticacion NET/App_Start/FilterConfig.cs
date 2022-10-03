using System.Web;
using System.Web.Mvc;

namespace Doble_Autenticacion_NET
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
