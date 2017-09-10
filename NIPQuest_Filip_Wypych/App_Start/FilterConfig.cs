using System.Web;
using System.Web.Mvc;

namespace NIPQuest_Filip_Wypych
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
