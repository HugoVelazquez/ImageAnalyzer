﻿using Microsoft.AspNetCore.Mvc;

namespace ImageAnalyzer.Api.Controllers;

public abstract class AnalyzerControllerBase : ControllerBase
{
    protected readonly IMediator _mediator;

    protected AnalyzerControllerBase(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected ActionResult HandleResponse(Response response, string logMessage)
    {
        if (!response.IsSuccessStatusCode)
        {
            return StatusCode((int)response.StatusCode, response.ValidationIssue);
        }

        return Ok();
    }

    protected ActionResult HandleResponse<T>(Response<T> response, string logMessage)
    {
        if (!response.IsSuccessStatusCode)
        {
            return StatusCode((int)response.StatusCode, response.ValidationIssue);
        }

        return Ok(response.Payload);
    }
}
