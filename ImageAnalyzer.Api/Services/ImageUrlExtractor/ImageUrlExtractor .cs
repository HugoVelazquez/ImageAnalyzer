using System.Text.RegularExpressions;

namespace ImageAnalyzer.Api.Services.ImageUrlExtractor;

public class ImageUrlExtractor : IImageUrlExtractor
{
    public List<string> Extract(string html)
    {
        List<string> imageUrls = new();

        var matches = ImageUrlRegex().Matches(html).Cast<Match>();

        foreach (Match match in matches)
        {
            string imageUrl = match.Groups[1].Value;
            if (IsValidUrl(imageUrl))
            {
                imageUrls.Add(imageUrl);
            }
        }

        return imageUrls;
    }

    public bool IsValidUrl(string url)
    {
        return Uri.TryCreate(url, UriKind.Absolute, out Uri? uriResult)
               && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
    }

    private static Regex ImageUrlRegex()
    {
        string pattern = @"<img.+?src=[\'](.+?)[\'].*?>";
        return new Regex(pattern);
    }
}