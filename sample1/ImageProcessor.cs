using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

public class ImageProcessor
{
    public static void resize(string imagePath, string imageSavePath, int width, int height)
    {
        using (Image image = Image.Load(imagePath))
        {
            image.Mutate(x => x.Resize(width, height));
            image.Save(imageSavePath);
        }
    }

    public static void resizeAll(string[] imagePaths, string[] imageSavePaths, int width, int height)
    {
        Parallel.ForEach(imagePaths, (imagePath, _, index) =>
        {
            using (Image image = Image.Load(imagePath))
            {
                image.Mutate(x => x.Resize(width, height));
                image.Save(imageSavePaths[index]);
            }
        });
    }
}