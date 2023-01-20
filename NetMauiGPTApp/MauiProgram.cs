using Microsoft.Extensions.Logging;
using NetMauiGPTApp.Services;
using NetMauiGPTApp.ViewModels;
using NetMauiGPTApp.Views;

namespace NetMauiGPTApp;

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

		builder.Services.AddSingleton<IOpenAIService, OpenAIService>();
		builder.Services.AddSingleton<ConversationViewModel>();
		builder.Services.AddSingleton<ConversationView>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
