using System;
using System.Collections.Generic;
using System.Text;

namespace AppCocacolaNay2.Interfaces.Navigation
{
    public interface INavigationService
    {
        void NavigateTo<TDestinationViewModel>(object navigationContext = null);

        void NavigateTo(Type destinationType, object navigationContext = null);

        void NavigateBack();
    }
}
