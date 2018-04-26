using System;
using System.IO;
using Xamarin.Forms;
using AppCocacolaNay2.Interfaces.SQLite;
using AppCocacolaNay2.Droid.Services.SQLite;

[assembly: Dependency(typeof(PathService))]
namespace AppCocacolaNay2.Droid.Services.SQLite
{
    public class PathService : IPathService
    {
        public string GetDatabasePath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, AppSettings.DatabaseName);
        }
    }
}