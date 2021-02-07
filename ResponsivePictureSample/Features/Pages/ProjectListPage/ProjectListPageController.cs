using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;

namespace ResponsivePictureSample.Features.Pages.ProjectListPage
{
    public class ProjectListPageController : ContentController<ProjectListPage>
    {
        private readonly IContentLoader _contentLoader;
        private readonly IUrlResolver _urlResolver;
        private readonly CategoryRepository _categoryRepository;

        public ProjectListPageController(IContentLoader contentLoader, IUrlResolver urlResolver, CategoryRepository categoryRepository)
        {
            _contentLoader = contentLoader;
            _urlResolver = urlResolver;
            _categoryRepository = categoryRepository;
        }
        
        public ActionResult Index(ProjectListPage currentContent)
        {
            var allProjects = _contentLoader.GetChildren<ProjectPage.ProjectPage>(currentContent.ContentLink)
                .Select(x => new ProjectTeaser(x.Title, BuildResponsiveImage(x.MainImage), x.Category
                    .Select(y => _categoryRepository.Get(y).Name)
                    .ToList(), _urlResolver.GetUrl(x.ContentLink)));

            return View(new ProjectListPageViewModel(currentContent, allProjects.ToList()));
        }

        private ResponsiveImageViewModel BuildResponsiveImage(ContentReference imageLink)
        {
            var image = _contentLoader.Get<Image.Image>(imageLink);
            if (image == null) return null;
            return new ResponsiveImageViewModel(_urlResolver.GetUrl(imageLink), image.FocalPoint, image.Width,
                image.Height, image.Description);
        }
    }
}