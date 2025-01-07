using CommunityToolkit.Maui;
using Lab5.MAUI.Interfaces;
using Lab5.MAUI.Services;
using Lab5.MAUI.ViewModels;
using Microsoft.Extensions.Logging;

namespace Lab5.MAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddScoped<IOwnerApiClient, OwnerApiClient>();
        builder.Services.AddScoped<IDataRepository, ApiDataRepository>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddScoped<AnimalsPageViewModel>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<AnimalsPage>();




#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

internal class AnimalsPage
{
}