﻿global using ImageAnalyzer.Api.Api;
global using ImageAnalyzer.Api.Configurations.Interfaces;
global using ImageAnalyzer.Api.Controllers;
global using ImageAnalyzer.Api.Features.Analysis.Commands.AnalyzeHtml;
global using ImageAnalyzer.Api.Features.Analysis.Commands.AnalyzeImageList;
global using ImageAnalyzer.Api.Features.Analysis.Requests;
global using ImageAnalyzer.Api.Features.Analysis.Responses;
global using ImageAnalyzer.Api.Services.AmazonRekognition.Interfaces;
global using ImageAnalyzer.Api.Services.AmazonS3.Interfaces;
global using ImageAnalyzer.Api.Services.ImageAnalysis;
global using ImageAnalyzer.Api.Services.ImageAnalysis.Interfaces;
global using ImageAnalyzer.Api.Services.ImageDownload.Interfaces;
global using ImageAnalyzer.Api.Services.ImageProcesor;
global using ImageAnalyzer.Api.Services.ImageProcesor.Enums;
global using ImageAnalyzer.Api.Services.ImageProcesor.Interfaces;
global using ImageAnalyzer.Api.Services.ImageUrlExtractor;
global using ImageAnalyzer.Api.Services.ImageUrlExtractor.Interfaces;
global using MediatR;
global using Moq;
global using System.Net;
global using Xunit;
