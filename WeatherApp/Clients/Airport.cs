using WeatherApp.NotifyServices;

namespace WeatherApp.Clients;

public class Airport(INotify notifyService) : IHasNotifyService
{
    public void Notify(string message)
    {
        notifyService.Notify(message);
    }
}