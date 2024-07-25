using Clean.Architecture.Core.User.entities;

namespace Clean.Architecture.Core.User.ValueObject
{
    public class User
    {
        public Email Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}