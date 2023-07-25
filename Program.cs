using Exceptions;

do
{
    Console.WriteLine("Input login: ");
    var _login = Console.ReadLine();
    Console.WriteLine("Input password: ");
    var _password = Console.ReadLine();
    Console.WriteLine("Confirm password: ");
    var _confirmPassword = Console.ReadLine();
    try
    {
        if (UserDataProvider.CheckData(_login, _password, _confirmPassword))
        {
            Console.WriteLine("True");
            break;
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
} while (true);

