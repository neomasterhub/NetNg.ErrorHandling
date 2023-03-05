namespace WebApi.Models;

public class ErrorModel
{
    public ErrorModel(Exception e)
    {
        Type = e.GetType().Name;
        Message = e.Message;
    }

    public string Type { get; }
    public string Message { get; }
}
