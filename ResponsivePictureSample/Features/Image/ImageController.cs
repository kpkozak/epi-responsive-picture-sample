using System.Web.Mvc;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Forte.EpiResponsivePicture.ResizedImage;

namespace ResponsivePictureSample.Features.Image
{
    [TemplateDescriptor(
        Inherited = true, 
        Default = true,
        AvailableWithoutTag = true
    )]
    public class ImageController : PartialContentController<Image>
    {
        public override ActionResult Index(Image currentContent)
        {
            var profile = ControllerContext.ParentActionViewContext.ViewData["PictureProfile"] as PictureProfile
                          ?? PictureProfiles.XHtmlString;

            ViewData["PictureProfile"] = profile;

            return PartialView("~/Features/Image/Image.cshtml", currentContent.ContentLink);
        }
    }
}