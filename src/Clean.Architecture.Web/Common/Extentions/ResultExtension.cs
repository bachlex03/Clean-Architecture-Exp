using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clean.Architecture.Core.common;

namespace Clean.Architecture.Web.Common.Extension
{
    public static class ResultExtension
    {
        public static IResult ToProblemDetails(this Result result)
        {
            return (IResult)Result.Problem(
               statusCode: "400",
               title: "Bad Request",
               error: result.Error
            );
        }
    }
}