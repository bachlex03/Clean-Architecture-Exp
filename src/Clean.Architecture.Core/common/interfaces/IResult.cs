using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.common.interfaces
{
    public interface IResult
    {
        public Result ToProblemDetails();
    }
}