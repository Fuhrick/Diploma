using System.Web;
using System.Web.Mvc;

namespace Diploma_1._0__FixedIdentity_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
