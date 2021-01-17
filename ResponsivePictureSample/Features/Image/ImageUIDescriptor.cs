using EPiServer.Shell;

namespace ResponsivePictureSample.Features.Image
{
    [UIDescriptorRegistration]
    public class ImageUIDescriptor : UIDescriptor<Image>, IEditorDropBehavior
    {
        public EditorDropBehavior EditorDropBehaviour { get; set; }

        public ImageUIDescriptor()
        {
            EditorDropBehaviour = EditorDropBehavior.CreateContentBlock;
        }
    }
}