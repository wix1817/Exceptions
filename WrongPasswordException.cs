﻿namespace Exceptions;

public class WrongPasswordException : Exception
{
    public WrongPasswordException() : base() {}

    public WrongPasswordException(string message) : base(message) {}
}