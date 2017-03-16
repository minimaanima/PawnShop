namespace PawnShop.Data.Exceptions
{
    using System;

    public class InvalidEmailOrPasswordException : Exception
    {
        public InvalidEmailOrPasswordException(string message) :
            base(message)
        {

        }
    }
}
