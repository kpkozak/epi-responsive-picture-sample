using System.Web.Mvc;
using EPiServer.Web.Mvc;

namespace ResponsivePictureSample.Features.Pages.ProjectPage
{
    public class ProjectPageController: ContentController<ProjectPage>
    {
        // todo is this controller redundant?
        public ActionResult Index(ProjectPage currentContent)
        {
            return View(currentContent);
        }
    }
}