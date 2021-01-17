using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace ResponsivePictureSample.Features.Image
{
    [ContentType(GUID = "FD23C075-1DCD-4EF9-9E60-505ACD34C211")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,gif,png")]
    public class Image : Forte.EpiResponsivePicture.ResizedImage.ImageBase
    {
    }
}