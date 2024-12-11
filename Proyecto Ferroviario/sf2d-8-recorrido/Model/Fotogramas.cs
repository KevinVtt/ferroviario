using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Media.Converters;

namespace SF2D.Model
{
    // esta clase debería ser estática porque se accede de distintos lados (RecorridoViewModel y CabinaViewModel)
    public class Fotogramas
    {
        private System.Timers.Timer _aceleracion; // velocidad a la que incrementa/decrementa la velocidad
        private System.Timers.Timer _velocidad; 
        private static double _minTimer = 40;
        private static double _maxTimer = 240;
        private double _incrementoTimer;
        private int _incrementoIdFotoActual = 1; // por ahora; desp puede ser -1 para retroceder.
        private int _idFotoActual; // Agregar 

        public System.Timers.Timer Velocidad { 
            get { return _velocidad; }
            set { _velocidad = value; }
        } // a la que cargan las fotos
        public int FotoActual { get { return _idFotoActual; } } // ID de la foto en la que está

        public Fotogramas() 
        {
            _aceleracion = new System.Timers.Timer(500);
            Velocidad = new System.Timers.Timer(_maxTimer);

            _idFotoActual = 1;

            _aceleracion.Elapsed += IncremetarTimer;
            Velocidad.Elapsed += IncrementarFotoActual;
        }

        //  MÉTODOS
        /// <summary>
        /// Reduce el timer de Velocidad para que _idFotoActual cambie más rápido.
        /// </summary>
        public void Acelerar()
        {
            _incrementoTimer = -10;
            _aceleracion.Start();
            if (!Velocidad.Enabled)
            {
                Velocidad.Start();
            }
        }

        /// <summary>
        /// Incrementa el timer de Velocidad para que _idFotoActual cambie más lento.
        /// </summary>
        public void Frenar() 
        {
            _incrementoTimer = 10;
            _aceleracion.Start();
            if (Velocidad.Enabled) 
            {
                Velocidad.Start();
            }
        }

        /// <summary>
        /// Detiene la aceleración o el frenado.
        /// </summary>
        public void CortarAccion()
        {
            _aceleracion.Stop();
            _incrementoTimer = 0;
        }

        /// <summary>
        /// Incrementa o decrementa Velocidad.
        /// Si Velocidad.Interval llega a _maxTimer, se detiene el timer.
        /// Si Velocidad.Interval supera a _minTimer, se setea _minTimer.
        /// </summary>
        private void IncremetarTimer(object sender, ElapsedEventArgs e)
        {
            if (Velocidad.Interval + _incrementoTimer < _minTimer)
            {
                Velocidad.Interval = _minTimer;
            } 
            else if (Velocidad.Interval + _incrementoTimer > _maxTimer)
            {
                Velocidad.Interval = _maxTimer;
                Velocidad.Stop();
            } 
            else
            {
                Velocidad.Interval += _incrementoTimer;
            }
        }

        private void IncrementarFotoActual(object sender, ElapsedEventArgs e)
        {
            // _incrementoIdFotoActual puede ser + o -.
            _idFotoActual += _incrementoIdFotoActual;
        }
    }
}
