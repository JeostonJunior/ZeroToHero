using System;

namespace Bank.Entities.Exceptions
{
    public class AccountException : ApplicationException
    {
        public AccountException (string message) : base(message)
        {
        }
    }
}
