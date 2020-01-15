using System;
using Microsoft.MobileBlazorBindings;
using Microsoft.Extensions.Hosting;
using Xamarin.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using System.IO;
using Microsoft.Extensions.DependencyInjection;

namespace TodoApp
{
    public class App : Application
    {
        public App()
        {
            var host = new HostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<AppState>();

                })
                .Build();

            host.AddComponent<TodoAppMainPage>(parent: this);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

    internal class FileProvider : IFileProvider
    {
        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            throw new NotImplementedException();
        }

        public IFileInfo GetFileInfo(string subpath)
        {
            throw new NotImplementedException();
        }

        public IChangeToken Watch(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
