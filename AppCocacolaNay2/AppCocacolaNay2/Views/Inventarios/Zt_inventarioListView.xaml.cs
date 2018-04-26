using AppCocacolaNay2.ViewModels;
using Xamarin.Forms;

namespace AppCocacolaNay2.Views.Inventarios
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Zt_inventarioListView : ContentPage
	{
        private object Parameter { get; set; }

        public Zt_inventarioListView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.Zt_inventariosListVM;
        }//Fin constructor

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as Zt_inventariosListVM;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }//Fin OnApperaring

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as Zt_inventariosListVM;
            if (viewModel != null) viewModel.OnDisappearing();
        }//Fin OnDisappearing
    }
}