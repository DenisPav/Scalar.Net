﻿using Microsoft.AspNetCore.Mvc;

namespace ScalarExample.Controllers;

[ApiController]
[Route("/api/values")]
[ProducesResponseType(typeof(IEnumerable<Value>), StatusCodes.Status200OK)]
public class ValueController
{
    /// <summary>
    /// Returns a list of values with Id and Name parameters
    /// 
    /// </summary>
    /// <returns>Returns a list of values with Id and Name parameters</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /api/values
    ///
    /// </remarks>
    /// <response code="200">Returns the newly created list of values</response>
    /// <response code="500">Internal server error</response>
    [HttpGet]
    public IActionResult Get()
    {
        var values = Enumerable.Range(1, 10)
            .Select(x => new Value(x, x.ToString()));

        return new OkObjectResult(values);
    }
}

public record Value(int Id, string Name);