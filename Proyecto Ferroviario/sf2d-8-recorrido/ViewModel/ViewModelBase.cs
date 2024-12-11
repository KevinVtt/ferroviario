using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SF2D.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        // [CallerMemberName] es una directiva de compilador
        // que toma como parámetro el atributo del setter si corresponde
        public void NotifyPropertyChanged([CallerMemberName] string? propName = null)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
