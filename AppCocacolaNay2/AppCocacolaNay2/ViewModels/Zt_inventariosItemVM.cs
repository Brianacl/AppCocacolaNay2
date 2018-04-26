using System.Collections.ObjectModel;
using AppCocacolaNay2.Models.Inventarios;
using AppCocacolaNay2.ViewModels.Base;
using System.Windows.Input;
using AppCocacolaNay2.Interfaces.Navigation;
using AppCocacolaNay2.Interfaces.SQLite;

namespace AppCocacolaNay2.ViewModels
{
    public class Zt_inventariosItemVM : ViewModelBase
    {
        private zt_inventarios _zt_inventarios;

        private ICommand _saveCommand;
        private ICommand _deleteCommand;
        private ICommand _cancelCommand;

        private INavigationService _navigationService;
        private ISQLiteService _sqliteService;

        public Zt_inventariosItemVM(
            INavigationService navigationService,
            ISQLiteService sqliteService)
        {
            _navigationService = navigationService;
            _sqliteService = sqliteService;
        }//Fin constructor

        public zt_inventarios Zt_inventario
        {
            get { return _zt_inventarios; }
            set
            {
                _zt_inventarios = value;
                RaisePropertyChanged();
            }
        }//Fin zt_inventario

        public ICommand SaveCommand
        {
            get { return _saveCommand = _saveCommand ?? new DelegateCommand(SaveCommandExecute); }
        }

        public ICommand DeleteCommand
        {
            get { return _deleteCommand = _deleteCommand ?? new DelegateCommand(DeleteCommandExecute); }
        }

        public ICommand CancelCommand
        {
            get { return _cancelCommand = _cancelCommand ?? new DelegateCommand(CancelCommandExecute); }
        }

        public override void OnAppearing(object navigationContext)
        {
            var zt_inventarioItem = navigationContext as zt_inventarios;

            if (zt_inventarioItem != null)
            {
                Zt_inventario = zt_inventarioItem;
            }

            base.OnAppearing(navigationContext);
        }//Fin OnAppearing

        private async void SaveCommandExecute()
        {
            await _sqliteService.Insert(Zt_inventario);
            _navigationService.NavigateBack();
        }//Fin SaveCommandExecute

        private async void DeleteCommandExecute()
        {
            await _sqliteService.Remove(Zt_inventario);
            _navigationService.NavigateBack();
        }//Fin DeleteCommandExecute

        private void CancelCommandExecute()
        {
            _navigationService.NavigateBack();
        }//Fin cancelCommandExecute
    }//Fin clase
}
