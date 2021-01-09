namespace UmbracoFolio.Web.Helpers
{
    public class NavigationHelper
    {
        public static bool IsPageActive(string pageUrl, string currentPageUrl)
        {
            return currentPageUrl.StartsWith(pageUrl);
        }
    }
}