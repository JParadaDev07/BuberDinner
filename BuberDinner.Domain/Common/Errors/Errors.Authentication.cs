using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using ErrorOr;

namespace BuberDinner.Domain.Common.Errors;

public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Validation(
            code: "Auth.InvalidCredentials",
            description: "Invalid credentials.");
    }
}