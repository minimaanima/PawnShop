namespace PawnShop.Data.Exceptions
{
    using System;

    public class PasswordsDontMatchException : Exception
    {
        public PasswordsDontMatchException(string text)
            : base(text)
        {
        }
    }
}
