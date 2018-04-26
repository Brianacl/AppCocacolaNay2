using AppCocacolaNay2.ViewModels;
using Xamarin.Forms;

namespace AppCocacolaNay2.Views.Inventarios
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Zt_inventariosItemView : ContentPage
	{

        private object Parameter { get; set; }

        public Zt_inventariosItemView (object parameter)
		{
			InitializeComponent ();

            Parameter = parameter;

            BindingContext = App.Locator.Zt_inventariosItemVM;
        }//Fin constructor

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as Zt_inventariosItemVM;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as Zt_inventariosItemVM;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}