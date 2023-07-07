namespace Exceptions;

public static class UserDataChecker
{
    private static bool IsGood { get; set; }

    public static bool CheckData(string login, string password, string confirmPassword)
    {
        try
        {
            if (login.Length > 1 & login.Length < 20 & !login.Contains(' '))
            {
                IsGood = true;
            }
            else
            {
                IsGood = false;
                if (login.Length is < 1 or > 20)
                {
                    throw new WrongLoginException("Input correct login");
                }

                if (login.Contains(' '))
                {
                    throw new WrongLoginException("Input login without spaces");
                }
            }


            if (password.Length < 20 & password.Length > 1 & password.Any(Char.IsDigit)
                & !password.Contains(' ') & confirmPassword == password)
            {
                IsGood = true;
            }
            else
            {
                IsGood = false;
                if (password.Length is < 1 or > 20)
                {
                    throw new WrongPasswordException("Wrong length of password");
                }

                if (!password.Any(Char.IsDigit))
                {
                    throw new WrongPasswordException("Input password with digits");
                }

                if (password.Contains(' '))
                {
                    throw new WrongPasswordException("Input password without spaces");
                }

                if (confirmPassword != password)
                {
                    throw new WrongPasswordException("Password not equals Confirm password");
                }
            }
        }
        catch (WrongLoginException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WrongPasswordException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return IsGood;
    }
}