using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
// ReSharper disable Mvc.TemplateNotResolved

namespace ResponsivePictureSample.Features.Pages.ProjectPage
{
    [ContentType(GUID = "4CCD0094-450D-449F-8B51-D7FF7A5A249F", DisplayName = "Project Page",
        Description = "Single project article")]
    [AvailableContentTypes(Availability.None)]
    public class ProjectPage : PageData
    {
        [Display(Order = 0)]
        public virtual string Title { get; set; }
        
        [Display(Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference MainImage { get; set; }

        [Display(Order = 20)]
        public virtual XhtmlString Description { get; set; }
        
        [Display(Order = 30)]
        public virtual ContentArea Images { get; set; }
    }
}