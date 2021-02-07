using Forte.EpiResponsivePicture.ResizedImage;

namespace ResponsivePictureSample.Features
{
    public static class PictureProfiles
    {
        public static readonly PictureProfile HeaderImage = new PictureProfile()
        {
            Format = ResizedImageFormat.Jpg,
            DefaultWidth = 800,
            Sources = new []
            {
                new PictureSource()
                {
                    MediaCondition = "max-width: 768px",
                    AllowedWidths = new [] {360, 480, 768},
                    Mode = ScaleMode.Crop,
                    TargetAspectRatio = AspectRatio.Create(3,4),
                    Sizes = new []
                    {
                        "95vw"
                    }
                }
            }
        };

        public static readonly PictureProfile XHtmlString = new PictureProfile()
        {
            Format = ResizedImageFormat.Jpg,
            DefaultWidth = 800,
            Sources = new []
            {
                new PictureSource()
                {
                    MediaCondition = "max-width: 768px",
                    AllowedWidths = new [] {360, 480, 768},
                    Mode = ScaleMode.Crop,
                    TargetAspectRatio = AspectRatio.Create(3,4),
                    Sizes = new []
                    {
                        "95vw"
                    }
                }
            }
        };

        public static readonly PictureProfile ProjectImagesGallery = new PictureProfile()
        {
            Format = ResizedImageFormat.Jpg,
            DefaultWidth = 800,
            Sources = new []
            {
                new PictureSource()
                {
                    MediaCondition = "max-width: 768px",
                    AllowedWidths = new [] {360, 480, 768},
                    Mode = ScaleMode.Crop,
                    TargetAspectRatio = AspectRatio.Create(3,4),
                    Sizes = new []
                    {
                        "95vw"
                    }
                }
            }
        };
    }
}