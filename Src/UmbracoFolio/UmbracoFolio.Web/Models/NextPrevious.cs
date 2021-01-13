using Umbraco.Core.Models.PublishedContent;

namespace UmbracoFolio.Web.Models
{
    public class NextPrevious<T> where T : IPublishedContent
    {
        public T Next { get; set; }

        public T Previous { get; set; }
    }
}