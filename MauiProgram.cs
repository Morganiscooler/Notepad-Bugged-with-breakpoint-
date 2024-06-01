using Microsoft.Extensions.Logging;
using Notepad__easy_.ViewModel;

namespace Notepad__easy_
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("FluentSystemIcons-Filled.ttf", "FluentIcons");
                    fonts.AddFont("FluentSystemIcons-Regular.ttf", "FluentIconsRegular");
                    fonts.AddFont("Segoe Fluent Icons.ttf", "FluentIconsReal");
                });

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            return builder.Build();
        }
    }
}
