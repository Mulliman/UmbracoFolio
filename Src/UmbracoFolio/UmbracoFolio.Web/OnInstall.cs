using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Umbraco.Core.PackageActions;
using Umbraco.Core;
using Umbraco.Core.Configuration.UmbracoSettings;
using Umbraco.Core.Logging;
using Umbraco.Core.Models;
using Umbraco.Core.PackageActions;
using Umbraco.Core.PropertyEditors.ValueConverters;
using Umbraco.Core.Services;
using Umbraco.Web.Composing;
using System.IO;
using System.Web.Hosting;

namespace UmbracoFolio.Web
{
    public class OnInstall : IPackageAction
    {
        public bool Execute(string packageName, XElement xmlData)
        {
            var contentService = Current.Services.ContentService;
            var mediaTypeService = Current.Services.MediaTypeService;
            var mediaService = Current.Services.MediaService;
            var dataTypeService = Current.Services.DataTypeService;
            var fileService = Current.Services.FileService;
            var contentSection = Current.Configs.Settings().Content;

            // create media folders

            this.CreateMediaItem(mediaService, mediaTypeService, -1, "folder", new Guid("775fb297-e31f-4980-9c9f-310cddccb7c3"), "UF Sample Logos", string.Empty, true);
            this.CreateMediaItem(mediaService, mediaTypeService, -1, "folder", new Guid("54a9a86b-da73-40a2-890b-f4294c39db44"), "UF Sample Pictures", string.Empty, true);

            // create media
            IMedia mediaRoot = mediaService.GetById(-1);
            IEnumerable<IMedia> rootMedia = mediaService.GetRootMedia().ToArray();
            try
            {
                foreach (XElement selectNode in xmlData.Elements("mediaItem"))
                {
                    IMedia media1 = mediaRoot;
                    foreach (IMedia media2 in rootMedia)
                    {
                        if (media2.Name.InvariantEquals((string)selectNode.Attribute("folder")))
                            media1 = media2;
                    }

                    // add UDI support
                    var key = selectNode.Attribute("key") != null &&
                              string.IsNullOrWhiteSpace((string)selectNode.Attribute("key")) == false
                        ? Guid.Parse((string)selectNode.Attribute("key"))
                        : Guid.Empty;

                    int mediaItem = CreateMediaItem(mediaService, mediaTypeService, media1.Id, "image", key, (string)selectNode.Attribute("name"), (string)selectNode.Attribute("path"), false);
                }
            }
            catch (Exception ex)
            {
                Current.Logger.Error<OnInstall>(ex, "Error Creating Media for UmbracoFolio");
            }

            var contentHome = contentService.GetRootContent().FirstOrDefault(x => x.ContentType.Alias == "ufHome");
            if (contentHome != null)
            {
                contentService.SaveAndPublishBranch(contentHome, true);
            }

            return true;
        }

        public bool Undo(string packageName, XElement xmlData)
        {
            return true;
        }

        public string Alias()
        {
            return "OnUmbracoFolioInstall";
        }

        private int CreateMediaItem(IMediaService service, IMediaTypeService mediaTypeService,
            int parentFolderId, string nodeTypeAlias, Guid key, string nodeName, string mediaPath, bool checkForDuplicateName = false)
        {
            //if the item with the exact id exists we cannot install it (the package was probably already installed)
            if (service.GetById(key) != null)
                return -1;

            //cannot continue if the media type doesn't exist
            var mediaType = mediaTypeService.Get(nodeTypeAlias);
            if (mediaType == null)
            {
                Current.Logger.Warn<OnInstall>("Media type does not exist", nodeTypeAlias);
                return -1;
            }

            var isDuplicate = false;

            if (checkForDuplicateName)
            {
                IEnumerable<IMedia> children;
                if (parentFolderId == -1)
                {
                    children = service.GetRootMedia();
                }
                else
                {
                    var parentFolder = service.GetById(parentFolderId);
                    if (parentFolder == null)
                    {
                        Current.Logger.Warn<OnInstall>("No media parent found by Id {ParentFolderId} the media item {NodeName} cannot be installed", parentFolderId, nodeName);
                        return -1;
                    }

                    children = service.GetPagedChildren(parentFolderId, 0, int.MaxValue, out long totalRecords);
                }
                foreach (var m in children)
                {
                    if (m.Name == nodeName)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
            }

            if (isDuplicate) return -1;

            if (parentFolderId != -1)
            {
                var parentFolder = service.GetById(parentFolderId);
                if (parentFolder == null)
                {
                    Current.Logger.Warn<OnInstall>("No media parent found by Id {ParentFolderId} the media item {NodeName} cannot be installed", parentFolderId, nodeName);
                    return -1;
                }
            }

            var media = service.CreateMedia(nodeName, parentFolderId, nodeTypeAlias);
            if (nodeTypeAlias != "folder")
            {
                var fileName = Path.GetFileName(mediaPath);
                using (var fs = System.IO.File.OpenRead(HostingEnvironment.MapPath(mediaPath)))
                {
                    media.SetValue(Current.Services.ContentTypeBaseServices, "umbracoFile", fileName, fs);
                }
            }

            if (key != Guid.Empty)
            {
                media.Key = key;
            }

            service.Save(media);
            return media.Id;
        }
    }
}