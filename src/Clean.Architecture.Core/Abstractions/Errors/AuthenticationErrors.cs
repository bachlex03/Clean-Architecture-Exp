using Clean.Architecture.Core.common;

namespace Clean.Architecture.Core.Abstractions.Errors
{
    public static class AuthenticationErrors
    {
        public static Error InvalidCredentials => Error.Unauthorized("auth.invalid_credentials", "Invalid credentials");
    }
}