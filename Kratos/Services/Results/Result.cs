﻿namespace Kratos.Services.Results
{
    public struct Result : IResult
    {
        public ResultType Type { get; set; }

        public string Message { get; set; }
    }
}
