using WeatherApp.Clients;

namespace WeatherApp;

public class WeatherManager
{
    private readonly HttpClient httpClient;
    private readonly HttpClientHandler clientHandler;
    private List<IHasNotifyService> notifyServices = [];

    public WeatherManager() 
    {
        clientHandler = new()
        {
            ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
            {
                return true;
            }
        };

        httpClient = new(clientHandler);
    }
    public string Get()
    {
        return "Жара 30 градусов";
    }

    public void Register(IHasNotifyService hasNotifyService)
    {
        notifyServices.Add(hasNotifyService);
    }

    public void Notify(string message)
    {
        foreach (var user in notifyServices)
        {
            user.Notify(message);
        }
    }
}