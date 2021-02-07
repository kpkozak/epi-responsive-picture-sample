using System.Collections.Generic;

namespace ResponsivePictureSample.Features.Pages.ProjectListPage
{
    public class ProjectTeaser
    {
        public ProjectTeaser(string name, ResponsiveImageViewModel image,
            IEnumerable<string> categories, string url)
        {
            Name = name;
            Image = image;
            Categories = categories;
            Url = url;
        }

        public string Name { get; }
        public ResponsiveImageViewModel Image { get; }
        public IEnumerable<string> Categories { get; }
        public string Url { get; }
    }
}