﻿using Amazon.Rekognition.Model;
using ImageAnalyzer.Api.Services.ImageProcesor;

namespace ImageAnalyzer.Api.Services.AmazonRekognition.Extensions;

public static class ModerationLabelExtensions
{
    public static ImageConfidence ToImageConfidence(this ModerationLabel moderationLabel) => new()
    {
        Confidence = moderationLabel.Confidence,
        Label = moderationLabel.Name,
        IsModeration = true
    };

    public static IEnumerable<ImageConfidence> ToImageConfidences(this List<ModerationLabel> moderationLabels)
    {
        return moderationLabels.Select(x => x.ToImageConfidence());
    }
}
