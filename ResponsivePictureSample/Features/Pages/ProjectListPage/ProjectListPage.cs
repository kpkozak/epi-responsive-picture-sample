using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
// ReSharper disable Mvc.TemplateNotResolved

namespace ResponsivePictureSample.Features.Pages.ProjectListPage
{
    [ContentType(GUID = "D8BC62BE-64F1-48A9-86D1-E14A7C43FB88", DisplayName = "Project list",
        Description = "Page listing all projects, grouped by categories")]
    [AvailableContentTypes(Availability.Specific, Include = new[] {typeof(ProjectPage.ProjectPage)})]
    public class ProjectListPage : PageData
    {
        [Display(Order = 10)]
        public virtual string Title { get; set; }
        
        [Display(Order = 20)]
        public virtual string Subtitle { get; set; }

        [Display(Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference MainImage { get; set; }
    }
}