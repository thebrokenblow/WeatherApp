using Microsoft.Extensions.DependencyInjection;
using WeatherApp;
using WeatherApp.Clients;
using WeatherApp.NotifyServices;

IServiceCollection services = new ServiceCollection();

services.AddTransient<INotify, EmailNotification>();
services.AddTransient<Airport>();
services.AddTransient<User>();

using var serviceProvider = services.BuildServiceProvider();
IHasNotifyService shirimetivo = serviceProvider.GetRequiredService<Airport>();
IHasNotifyService domodedovo = serviceProvider.GetRequiredService<Airport>();
IHasNotifyService artem = serviceProvider.GetRequiredService<User>();


var weatherManager = new WeatherManager();
var weather = weatherManager.Get();
weatherManager.Register(domodedovo);
weatherManager.Register(shirimetivo);
weatherManager.Register(artem);


weatherManager.Notify(weather);