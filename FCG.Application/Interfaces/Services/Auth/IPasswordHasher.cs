﻿namespace FCG.Application.Interfaces.Services.Auth
{
    public interface IPasswordHasher
    {
        string Hash(string password);
        bool Verify(string password, string hash);
    }
}