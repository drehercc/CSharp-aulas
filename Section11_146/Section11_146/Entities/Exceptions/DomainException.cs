using System;
namespace Section11_146.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }

    }
}
