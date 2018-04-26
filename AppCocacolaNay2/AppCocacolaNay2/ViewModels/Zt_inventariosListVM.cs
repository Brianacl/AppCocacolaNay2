using System.Collections.ObjectModel;
using AppCocacolaNay2.Models.Inventarios;
using AppCocacolaNay2.ViewModels.Base;
using System.Windows.Input;
using AppCocacolaNay2.Interfaces.Navigation;
using AppCocacolaNay2.Interfaces.SQLite;

namespace AppCocacolaNay2.ViewModels
{
    public class Zt_inventariosListVM : ViewModelBase
    {
        private ObservableCollection<zt_inventarios> _zt_inventario;
        private zt_inventarios _selectedZt_inventario;

        private ICommand _addCommand;

        private INavigationService _navigationService;
        private ISQLiteService _sqliteService;

        public Zt_inventariosListVM(
            INavigationService navigationService,
            ISQLiteService sqliteService)
        {
            _navigationService = navigationService;
            _sqliteService = sqliteService;
        }//Fin constructor

        public ObservableCollection<zt_inventarios> Zt_inventarios
        {
            get { return _zt_inventario; }
            set
            {
                _zt_inventario = value;
                RaisePropertyChanged();
            }
        }//Fin Zt_inventarios

        public zt_inventarios SelectedZt_inventario
        {
            get { return _selectedZt_inventario; }
            set
            {
                _selectedZt_inventario = value;
                _navigationService.NavigateTo<Zt_inventariosItemVM>(_selectedZt_inventario);
            }
        }//Fin selectedZt_inventario

        public ICommand AddCommand
        {
            get { return _addCommand = _addCommand ?? new DelegateCommand(AddCommandExecute); }
        }//Fin AddCommand

        public override async void OnAppearing(object navigationContext)
        {
            base.OnAppearing(navigationContext);

            var result = await _sqliteService.GetAll();

            Zt_inventarios = new ObservableCollection<zt_inventarios>();
            foreach (var zt_inventario in result)
            {
                Zt_inventarios.Add(zt_inventario);
            }
        }//Fin OnAppearing

        private void AddCommandExecute()
        {
            var zt_inventarioItem = new zt_inventarios();
            _navigationService.NavigateTo<Zt_inventariosItemVM>(zt_inventarioItem);
        }//Fin AddCommandExecute
    }
}
