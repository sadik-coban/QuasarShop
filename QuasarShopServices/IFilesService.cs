using SixLabors.ImageSharp.Formats.Jpeg;

namespace QuasarShopServices;

public interface IFilesService
{
    Task<string> ResizeImage(Stream imageStrem, Stream watermarkImage, Size size);
    Task<string> ResizeImage(Stream imageStrem, Stream watermarkImage, int width, int height);
}

public class FileService : IFilesService
{
    public async Task<string> ResizeImage(Stream imageStrem, Stream watermarkImage, Size size)
    {
        var image = await Image.LoadAsync(imageStrem);

        image.Mutate(p =>
        {
            p.Resize(new ResizeOptions
            {
                Size = size,
                Mode = ResizeMode.Pad
            });
        });
        image.Mutate(p =>
        {
            var watermark = Image.Load(watermarkImage);
            p.DrawImage(watermark, 0.3f);
        });
        return image.ToBase64String(JpegFormat.Instance);
    }

    public Task<string> ResizeImage(Stream imageStrem, Stream watermarkImage, int width, int height)
    {
        return ResizeImage(imageStrem, watermarkImage, new Size(width, height));    
    }
}