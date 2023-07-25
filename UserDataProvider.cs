namespace Exceptions;

public static class UserDataProvider
{
    private static void LoginVerification(string login)
    {
        if (login.Length is < 1 or > 20)
            throw new WrongLoginException("Input correct login");
        if (login.Contains(' '))
            throw new WrongLoginException("Input login without spaces");
    }

    private static void PasswordVerification(string password, string confirmPassword)
    {
        if (password.Length is < 1 or > 20)
            throw new WrongPasswordException("Wrong length of password");
        if (!password.Any(Char.IsDigit))
            throw new WrongPasswordException("Input password with digits");
        if (password.Contains(' '))
            throw new WrongPasswordException("Input password without spaces");
        if (confirmPassword != password)
            throw new WrongPasswordException("Password not equals Confirm password");
    }
    
    public static bool CheckData(string login, string password, string confirmPassword)
    {
        LoginVerification(login);
        PasswordVerification(password, confirmPassword);
        return true;
    }
}