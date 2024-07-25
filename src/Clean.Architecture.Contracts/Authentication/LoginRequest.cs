namespace Clean.Architecture.Contracts.Authentication
{
    public sealed record LoginRequest(string Email, string Password)
    {

    }
}