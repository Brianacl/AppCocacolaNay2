using Autofac;
using AppCocacolaNay2.Interfaces.Navigation;
using AppCocacolaNay2.Services.Navigation;
using AppCocacolaNay2.Interfaces.SQLite;
using AppCocacolaNay2.Services.SQLite;

namespace AppCocacolaNay2.ViewModels.Base
{
    public class ViewModelLocator
    {
        private static IContainer _container;

        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();

            // ViewModels
            builder.RegisterType<Zt_inventariosListVM>();
            builder.RegisterType<Zt_inventariosItemVM>();

            // Services     
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            builder.RegisterType<SQLiteService>().As<ISQLiteService>();

            if (_container != null)
            {
                _container.Dispose();
            }

            _container = builder.Build();
        }//Fin constructor

        public Zt_inventariosListVM Zt_inventariosListVM
        {
            get { return _container.Resolve<Zt_inventariosListVM>(); }
        }

        public Zt_inventariosItemVM Zt_inventariosItemVM
        {
            get { return _container.Resolve<Zt_inventariosItemVM>(); }
        }
    }
}
