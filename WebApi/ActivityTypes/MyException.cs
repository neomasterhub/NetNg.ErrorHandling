namespace WebApi.ActivityTypes;

public class MyException : Exception
{
    public MyException(string message, Exception innerException = null)
        : base(message, innerException)
    {
    }
}
