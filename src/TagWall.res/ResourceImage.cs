using System.Reflection;
using System.Windows.Media.Imaging;

namespace TagWall.res
{
    public static class ResourceImage
    {
        public static BitmapImage GetImage(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(typeof(ResourceImage).Namespace + ".Images.Icons." + name);

            var image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();

            return image;
        }
    }
}
