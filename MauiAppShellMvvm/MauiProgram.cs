using BankingLocalMaui.Services;
using MauiAppShellMvvm.Configuration;
using MauiAppShellMvvm.Services;
using MauiAppShellMvvm.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiAppShellMvvm
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.RegisterServices()
               .RegisterViewModels()
               .RegisterViews();
            return builder.Build();
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<IExampleCounterStore, ExampleLocalDatabase>();
            mauiAppBuilder.Services.AddTransient<ISettings, ExampleSettings>();

            // More services registered here.

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<MainViewModel>();

            // More view-models registered here.

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<MainView>();

            // More views registered here.

            return mauiAppBuilder;
        }
    }
}
