using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Core.CrossCuttingConcern.Caching;
using Core.CrossCuttingConcern.Caching.Microsoft;

namespace Core.DependencyResolver
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollention)
        {
            serviceCollention.AddMemoryCache();
            serviceCollention.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollention.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollention.AddSingleton<Stopwatch>();
        }
    }
}
