using System.Runtime.CompilerServices;

namespace JavascriptWrapper.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddPaulsMessages(this IServiceCollection services)
            => services.AddScoped<PaulsMessageService>();
    }
}
