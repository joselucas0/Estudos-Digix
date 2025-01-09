using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09_01
{
    public class Exceptio
    {
        public class InvalidTransactionException : Exception
    {
        public InvalidTransactionException(string message) : base(message) { }
    }

    public class AuthenticationException : Exception
        {
            public AuthenticationException(string message) : base(message) { }
        }

    public class AccountNotFoundException : Exception
        {
        public AccountNotFoundException(string message) : base(message) { }
        }
        }
}