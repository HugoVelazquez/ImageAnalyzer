using ImageAnalyzer.Api.Configurations.Interfaces;
using ImageAnalyzer.Api.Services.AmazonRekognition;
using ImageAnalyzer.Api.Services.AmazonRekognition.Interfaces;
using ImageAnalyzer.Api.Services.AmazonS3;
using ImageAnalyzer.Api.Services.AmazonS3.Interfaces;
using ImageAnalyzer.Api.Services.ImageAnalysis;
using ImageAnalyzer.Api.Services.ImageAnalysis.Interfaces;
using ImageAnalyzer.Api.Services.ImageDownload;
using ImageAnalyzer.Api.Services.ImageDownload.Interfaces;
using ImageAnalyzer.Api.Services.ImageProcesor;
using ImageAnalyzer.Api.Services.ImageProcesor.Interfaces;
using ImageAnalyzer.Api.Services.ImageUrlExtractor.Interfaces;

namespace ImageAnalyzer.Api.Configurations;

public static class ServiceConfiguration
{
    public static IServiceCollection AddOperationsLogic(this IServiceCollection services, IAppConfiguration config)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());
        services.AddSingleton(_ => config);
        services.AddAmazonS3(config!.Amazon!);
        services.AddAmazonRekognition(config!.Amazon!);
        services.AddScoped<IAnalysisOrchestrator, AnalysisOrchestrator>();
        services.AddScoped<IImageUrlExtractor, ImageUrlExtractor>();
        services.AddScoped<IImageProcessor, ImageProcessor>();
        services.AddScoped<IImageDownloadClient, ImageDownloadClient>();
        services.AddScoped<IS3Client, S3Client>();
        services.AddScoped<IRekognitionClient, RekognitionClient>();
        services.AddHttpClient();

        return services;
    }
}
