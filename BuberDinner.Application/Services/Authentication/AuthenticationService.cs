using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Register(string firstName, string lastName, string Email, string Password)
    {
        //1.- Validate the user doesn't already exist
        if (_userRepository.GetUserByEmail(Email) != null)
            throw new Exception("The user with the given email already exists.");

        //2.- Create user (generate unique id) & Persist to DB

        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = Email,
            Password = Password
        };

        _userRepository.Add(user);

        //3.- Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }

    public AuthenticationResult Login(string Email, string Password)
    {
        //1.- Validate the user exists
        if (_userRepository.GetUserByEmail(Email) is not User user)
        {
            throw new Exception("The user with the given email doesn't exist.");
        }

        //2.- Validate the password is correct
        if (user.Password != Password)
        {
            throw new Exception("The password is incorrect.");
        }

        //3.- Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}