using Blazorise;
using Microsoft.Extensions.Logging;
using Blazorise;
using Blazorise.Icons.FontAwesome;
using Blazorise.Bootstrap;
<<<<<<< HEAD:Assignments/AssignmentAbsClassesEventDrivenAppsExceptionHandling/Assignment2/MauiProgram.cs
=======
using System.IO;
>>>>>>> 4e615a340440f6b73cea8cf3383572806d598e91:Assignments/AssignmentAbsClassesEventDrivenAppsExceptionHandling/Assignment2/Assignment2-final/MauiProgram.cs

namespace Assignment2
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
            builder.Services.AddBlazorise().AddBootstrapProviders().AddFontAwesomeIcons();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
<<<<<<< HEAD:Assignments/AssignmentAbsClassesEventDrivenAppsExceptionHandling/Assignment2/MauiProgram.cs
    		builder.Logging.AddDebug();
=======
            builder.Logging.AddDebug();
>>>>>>> 4e615a340440f6b73cea8cf3383572806d598e91:Assignments/AssignmentAbsClassesEventDrivenAppsExceptionHandling/Assignment2/Assignment2-final/MauiProgram.cs
#endif

            return builder.Build();
        }
    }
}
