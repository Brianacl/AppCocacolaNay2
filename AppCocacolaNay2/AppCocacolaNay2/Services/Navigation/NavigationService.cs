using AppCocacolaNay2.Interfaces.Navigation;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using AppCocacolaNay2.ViewModels;
using AppCocacolaNay2.Views.Inventarios;

namespace AppCocacolaNay2.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        private IDictionary<Type, Type> viewModelRouting = new Dictionary<Type, Type>()
        {
            { typeof(Zt_inventariosListVM),  typeof(Zt_inventarioListView) },
            { typeof(Zt_inventariosItemVM), typeof(Zt_inventariosItemView) }
        };

        public void NavigateTo<TDestinationViewModel>(object navigationContext = null)
        {
            Type pageType = viewModelRouting[typeof(TDestinationViewModel)];
            var page = Activator.CreateInstance(pageType, navigationContext) as Page;

            if (page != null)
                Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public void NavigateTo(Type destinationType, object navigationContext = null)
        {
            Type pageType = viewModelRouting[destinationType];
            var page = Activator.CreateInstance(pageType, navigationContext) as Page;

            if (page != null)
                Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public void NavigateBack()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
