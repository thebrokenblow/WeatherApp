using WeatherApp.NotifyServices;

namespace WeatherApp.Clients;

public class User(INotify notifyService) : IHasNotifyService
{
    //Свойства пользователя

    public void Notify(string message)
    {
        notifyService.Notify(message);
    }

    //Методы пользователя
}
