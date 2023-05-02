namespace ImageAnalyzer.Api.Services.ImageDownload.Interfaces;

public interface IImageDownloadClient
{
    Task<Stream?> GetImageStream(string url, CancellationToken cancellationToken = default);
}
