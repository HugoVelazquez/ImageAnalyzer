﻿using ImageAnalyzer.Api.Features.Analysis.Responses;

namespace ImageAnalyzer.Api.Services.ImageAnalysis.Interfaces;

public interface IAnalysisOrchestrator
{
    Task<List<ImageAnalysisResponse>> ProcessImageList(List<string> imageList, string? analysisType, CancellationToken cancellationToken);
}
