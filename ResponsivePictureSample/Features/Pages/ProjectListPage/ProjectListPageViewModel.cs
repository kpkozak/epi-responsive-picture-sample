using System.Collections.Generic;

namespace ResponsivePictureSample.Features.Pages.ProjectListPage
{
    public class ProjectListPageViewModel
    {
        public ProjectListPageViewModel(ProjectListPage content, IEnumerable<ProjectTeaser> projects)
        {
            Projects = projects;
            Content = content;
        }

        public IEnumerable<ProjectTeaser> Projects { get; }
        public ProjectListPage Content { get; }
    }
}