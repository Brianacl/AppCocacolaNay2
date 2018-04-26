using System;
using System.IO;
using Xamarin.Forms;
using AppCocacolaNay2.Interfaces.SQLite;
using Windows.Storage;
using AppCocacolaNay2.UWP.Services.SQLite;

[assembly: Dependency(typeof(PathService))]
namespace AppCocacolaNay2.UWP.Services.SQLite
{
    public class PathService : IPathService
    {
        public string GetDatabasePath()
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, AppSettings.DatabaseName);
        }
    }
}
