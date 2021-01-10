namespace UmbracoFolio.Web.Helpers
{
    public class NavigationHelper
    {
        public static bool IsPageActive(string pageUrl, string currentPagePath)
        {
            return currentPagePath.StartsWith(pageUrl);
        }
    }
}