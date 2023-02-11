using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using NetMauiGPTApp.Services;
using NetMauiGPTApp.ViewModels;
using NetMauiGPTApp.Views;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace NetMauiGPTApp;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
        .UseSkiaSharp()
        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("Mona-Sans-Bold.ttf", "MonaSansBold");
            fonts.AddFont("Mona-Sans-Medium.ttf", "MonaSansMedium");
        }).UseMauiCommunityToolkit();

        builder.Services.AddSingleton<IOpenAIService, OpenAIService>();
        builder.Services.AddTransient<ConversationViewModel>();
        builder.Services.AddSingleton<ConversationView>();

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}