namespace WebApi.ActivityTypes;

public class Error
{
    public Error(Exception e)
    {
        Type = e.GetType().Name;
        Message = e.Message;
    }

    public string Type { get; }
    public string Message { get; }
}
