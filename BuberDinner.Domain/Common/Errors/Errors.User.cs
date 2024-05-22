using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using ErrorOr;

namespace BuberDinner.Domain.Common.Errors;

public static partial class Errors
{
    public static class User
    {
        public static Error DuplicateEmail => Error.Conflict(
            code: "User.DuplicateEmail",
            description: "The user with the given email already exists.");
    }
}