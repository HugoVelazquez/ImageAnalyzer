﻿using ImageAnalyzer.Api.Configurations.Amazon;
using ImageAnalyzer.Api.Configurations.Interfaces;

namespace ImageAnalyzer.Api.Configurations;

public class AppConfiguration : IAppConfiguration
{
    public AmazonConfiguration? Amazon { get; set; }
    public AmazonS3Configuration? AmazonS3 { get; set; }
    public AmazonRekognitionConfiguration? AmazonRekognition { get; set; }
}
