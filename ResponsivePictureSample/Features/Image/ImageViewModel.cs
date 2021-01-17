using EPiServer.Core;
using Forte.EpiResponsivePicture.ResizedImage;

namespace ResponsivePictureSample.Features.Image
{
    public class ImageViewModel
    {
        public ContentReference Image { get; }
        public PictureProfile Profile { get; }

        public ImageViewModel(ContentReference image, PictureProfile profile)
        {
            Image = image;
            Profile = profile;
        }
    }
}