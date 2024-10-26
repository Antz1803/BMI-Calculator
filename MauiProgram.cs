using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace BMI
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
                    fonts.AddFont("ComicSansMS.ttf", "ComicSansMS");
                })
                .ConfigureSyncfusionCore();

            return builder.Build();
        }
    }
}
