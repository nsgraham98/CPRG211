using DemoMod9SQLiteWithoutExtension.Services;
using Microsoft.Extensions.Logging;

namespace DemoMod9SQLiteWithoutExtension
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
				});

			builder.Services.AddMauiBlazorWebView();

			// allows maui to access database path
			var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"ProductDB.db");
			builder.Services.AddSingleton<ProductService>(p => ActivatorUtilities.CreateInstance<ProductService>(p,dbPath));

#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
