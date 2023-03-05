namespace WebApi.Models;

public class ErrorModel
{
    public ErrorModel(Exception e)
    {
        ExceptionTypeName = e.GetType().Name;
        Message = e.Message;
    }

    public string ExceptionTypeName { get; }
    public string Message { get; }
}
