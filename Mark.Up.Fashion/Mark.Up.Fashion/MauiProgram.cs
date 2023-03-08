using Microsoft.AspNetCore.Components.WebView.Maui;
using Mark.Up.Fashion;
using Microsoft.Extensions.Configuration;
using Mark.Up.Fashion.Data;
using Microsoft.EntityFrameworkCore;
using static Mark.Up.Fashion.Data.MarkupCoreEF;

namespace Mark.Up.Fashion;

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
        builder.Services.AddDbContext<DataContext>
                (options => options.UseMySql(builder.Configuration.GetConnectionString("MySQLConnection"), new MySqlServerVersion(new Version())));

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		return builder.Build();
	}
}
