﻿using Neomaster.Extensions.Exception;
using WebApi.ActivityTypes;

namespace WebApi.Models;

public class ErrorModel
{
    public ErrorModel(Exception e)
    {
        ErrorStack = e
            .GetAllInnerExceptions()
            .Select(e => new Error(e));
    }

    public IEnumerable<Error> ErrorStack { get; }
}
