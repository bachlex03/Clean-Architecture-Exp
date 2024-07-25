
using Clean.Architecture.Core.Enums;

namespace Clean.Architecture.Core.common
{
    public sealed record Error
    {
        public string Code { get; }
        public string Description { get; }
        public ErrorType ErrorType { get; }

        private Error(string code, string description, ErrorType errorType)
        {
            Code = code;
            Description = description;
            ErrorType = errorType;
        }

        public static Error None => new(string.Empty, string.Empty, ErrorType.Failure);
        public static Error NotFound(string code, string description) => new(code, description, ErrorType.NotFound);
        public static Error Unauthorized(string code, string description) => new(code, description, ErrorType.Unauthorized);
    }
}