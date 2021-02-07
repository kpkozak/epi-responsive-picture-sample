using Forte.EpiResponsivePicture.ResizedImage;

namespace ResponsivePictureSample.Features
{
    public static class PictureProfiles
    {
        public static readonly PictureProfile HeaderImage = new PictureProfile
        {
            Format = ResizedImageFormat.Jpg,
            DefaultWidth = 1920,
            Sources = new[]
            {
                new PictureSource
                {
                    MediaCondition = "(min-width: 1024px)",
                    AllowedWidths = new[] {1920, 1440, 1280, 1024},
                    Mode = ScaleMode.Crop,
                    TargetAspectRatio = AspectRatio.Create(16,5.4), // 60vh for 16:9 screens
                    Sizes = new[]
                    {
                        "100vw"
                    },
                    Quality = 60
                },
                new PictureSource
                {
                    AllowedWidths = new[] {360, 375, 425, 750, 1050, 1125},
                    Mode = ScaleMode.Crop,
                    TargetAspectRatio = AspectRatio.Create(9, 16),
                    Sizes = new[]
                    {
                        "100vw"
                    },
                    Quality = 60
                },
            },
        };

        public static readonly PictureProfile XHtmlString = new PictureProfile()
        {
            Format = ResizedImageFormat.Jpg,
            DefaultWidth = 800,
            Sources = new[]
            {
                new PictureSource
                {
                    AllowedWidths = new[] {360, 480, 768, 1024, 1280, 1440},
                    Mode = ScaleMode.Default,
                    TargetAspectRatio = AspectRatio.Original,
                    Sizes = new[]
                    {
                        "(max-width: 1480px) 100vw",
                        "1440px"
                    },
                    Quality = 80
                }
            }
        };

        public static readonly PictureProfile ProjectImagesGallery = new PictureProfile()
        {
            Format = ResizedImageFormat.Jpg,
            DefaultWidth = 800,
            Sources = new[]
            {
                new PictureSource()
                {
                    MediaCondition = "(min-width: 1024px)",
                    AllowedWidths = new[] {960,640,480,430,345},
                    Mode = ScaleMode.Crop,
                    TargetAspectRatio = AspectRatio.Create(4, 3),
                    Sizes = new[]
                    {
                        "30vw"
                    },
                    Quality = 80
                },
                new PictureSource()
                {
                    AllowedWidths = new[] {215,375,525,640,960},
                    Mode = ScaleMode.Crop,
                    TargetAspectRatio = AspectRatio.Create(1, 1),
                    Sizes = new[]
                    {
                        "50vw"
                    },
                    Quality = 80
                }
            }
        };
    }
}