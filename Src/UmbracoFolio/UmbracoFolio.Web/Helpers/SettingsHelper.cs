using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.PublishedModels;

namespace UmbracoFolio.Web.Helpers
{
    public class SettingsHelper
    {
        public static IPublishedContent GetSettingsFolder(IPublishedContent content)
        {
            var home = content.Root();

            var settingsFolder = home.FirstChildOfType(UfConfigurationFolder.ModelTypeAlias);

            return settingsFolder;
        }

        public static UfSiteConfiguration GetSiteSettings(IPublishedContent content)
        {
            var folder = GetSettingsFolder(content);

            if (folder == null) return null;

            var settings = folder.FirstChildOfType(UfSiteConfiguration.ModelTypeAlias);

            return settings as UfSiteConfiguration;
        }
    }
}