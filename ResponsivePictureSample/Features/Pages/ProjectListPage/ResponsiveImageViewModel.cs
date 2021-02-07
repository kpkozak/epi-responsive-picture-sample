using Forte.EpiResponsivePicture.ResizedImage.Property;

namespace ResponsivePictureSample.Features.Pages.ProjectListPage
{
    public class ResponsiveImageViewModel
    {
        public ResponsiveImageViewModel(string url, FocalPoint focalPoint, int width, int height, string alt)
        {
            Url = url;
            FocalPoint = focalPoint;
            Width = width;
            Height = height;
            Alt = alt;
        }

        public string Url { get; }
        public FocalPoint FocalPoint { get; }
        public int Width { get; }
        public int Height { get; }
        public string Alt { get; }
    }
}