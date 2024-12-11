using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.IO;
using System.Diagnostics;
using SF2D.Model;
using SF2D.ViewModel;
using System.Windows.Threading;
using System.Windows.Data;
using System.Runtime.Intrinsics.Arm;

namespace SF2D.View
{

    // Muchas de las funcionalidades que están acá, me parece que van en el ViewModels correspondiente

    public partial class RecorridoView : UserControl
    {
        private static RecorridoViewModel _rvm = new();

        public RecorridoView()
        {
            InitializeComponent();
            DataContext = _rvm;

            RecorridoBinding();
        }


        /// <summary>
        /// Bindea la Image Recorrido a la FotoActual del ViewModel.
        /// </summary>
        private void RecorridoBinding()
        {
            Binding b = new("FotoActual");
            b.Source = _rvm;
            Recorrido.SetBinding(Image.SourceProperty, b);
        }
    }
}
