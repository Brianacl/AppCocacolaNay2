using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppCocacolaNay2.ViewModels.Base
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public virtual void OnAppearing(object navigationContext)
        {
        }//Fin OnAppearing

        public virtual void OnDisappearing()
        {
        }//Fin OnDisappearing

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
