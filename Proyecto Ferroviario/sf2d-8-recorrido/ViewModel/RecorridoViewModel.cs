using SF2D.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Path = System.IO.Path;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Windows;

namespace SF2D.ViewModel
{
    public class RecorridoViewModel : ViewModelBase
    {
        private static string _path = "D:\\Facultad\\Ferroviario\\Fotogramas"; // ruta en donde se aloja nuestros fotogramas; busquemos que use la carpeta Resources
        private static DispatcherTimer _timer = new();  // usamos el timer que corresponde a cosas visuales, o sea el Dispatcher
        private static Fotogramas _fotogramas = new();
        private BitmapImage? _fotoActual;

        public RecorridoViewModel()
        {
            _fotogramas.Acelerar(); // esto es provisorio
            IniciarAnimacion();
        }

        /// <summary>
        /// Setearlo con este método avisa a la interfaz (View) que la foto cambió.
        /// </summary>
        public BitmapImage? FotoActual
        {
            get { return _fotoActual; }
            set
            {
                _fotoActual = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Setea todo para que el Dispatcher empiece a mostrar imagenes.
        /// </summary>
        private void IniciarAnimacion()
        {
            _timer.Interval = TimeSpan.FromMilliseconds(_fotogramas.Velocidad.Interval);
            _timer.Tick += ActualizacionFrames;
            _timer.Tick += SincronizarTimer;
            _timer.Start();
        }


        /// <summary>
        /// Setea this.FotoActual según corresponda
        /// La acción es realizada en el mismo hilo que _timer.
        /// </summary>
        private void ActualizacionFrames(object sender, EventArgs e)
        {
            _timer.Dispatcher.Invoke(
                () =>
                {
                    string imagePath = Path.Combine(
                        _path, $"({_fotogramas.FotoActual}).png"
                        );

                    if (File.Exists(imagePath))
                        this.FotoActual = new BitmapImage(new Uri(imagePath));

                    else
                        Debug.WriteLine(imagePath + " no existe");
                },
                DispatcherPriority.Send
                );
        }

        /// <summary>
        /// Sincroniza el intervalo de DispatcherTimer con el de Velocidad
        /// </summary>
        private void SincronizarTimer(object sender, EventArgs e)
        {
            _timer.Interval = TimeSpan.FromMilliseconds(_fotogramas.Velocidad.Interval);
        }

    }



}
