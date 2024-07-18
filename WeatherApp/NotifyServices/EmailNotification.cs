namespace WeatherApp.NotifyServices;

public class EmailNotification : INotify
{
    public void Notify(string message)
    {
        Console.WriteLine($"{message} Уведомление по почте");
    }
}