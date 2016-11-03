using System.Web;
using System.Web.Mvc;

namespace Comp229_F2016_Lesoon8
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
