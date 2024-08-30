using Microsoft.Extensions.DependencyInjection;
using PasswordGeneratorApp.Generator;

namespace UnitTests
{
    public static class Helper
    {
        private static IServiceProvider Provider()
        {
            var services = new ServiceCollection()
                .AddScoped<IPasswordGeneratable, PasswordGenerator>();

            return services.BuildServiceProvider();
        }

        public static T GetServiceProvider<T>()
        {
            var provider = Provider();

            return provider.GetRequiredService<T>();
        }
    }
}
