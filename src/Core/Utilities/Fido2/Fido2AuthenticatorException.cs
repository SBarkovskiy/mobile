namespace Bit.Core.Utilities.Fido2
{
    public class Fido2AuthenticatorException : Exception
    {
        public Fido2AuthenticatorException(string message) : base(message)
        {
        }
    }

    public class NotAllowedError : Fido2AuthenticatorException
    {
        public NotAllowedError() : base("NotAllowedError")
        {
        }
    }

    public class NotSupportedError : Fido2AuthenticatorException
    {
        public NotSupportedError() : base("NotSupportedError")
        {
        }
    }

    public class UnknownError : Fido2AuthenticatorException
    {
        public UnknownError() : base("UnknownError")
        {
        }
    }
}