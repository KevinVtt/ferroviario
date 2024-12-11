using models.bobina;
using repository.bobinas;
using System;
using System.Collections.ObjectModel;

namespace bobinas.viewmodel
{
    public class BobinasViewModel
    {
        public readonly BobinasRepository _repository;

        // ObservableCollection permite actualizar automáticamente la interfaz cuando se modifica la colección.
        public ObservableCollection<Bobina> Bobinas { get; private set; }

        public string MensajeEstado { get; private set; }

        public BobinasViewModel()
        {
            _repository = new BobinasRepository();
            Bobinas = new ObservableCollection<Bobina>(); // Inicializa la colección vacía.
        }

        /// <summary>
        /// Metodo para mostrar las bobinas que se encuentran en la BD.
        /// </summary>

        public async Task CargarBobinas()
        {
            try
            {
                MensajeEstado = "Cargando datos, por favor espere...";
                var bobinas = await _repository.GetAllAsync(); // Obtiene las bobinas desde el repositorio.
                Bobinas.Clear(); // Limpia los datos existentes.
                foreach (var bobina in bobinas)
                {
                    Bobinas.Add(bobina); // Agrega las bobinas a la colección.
                }
                MensajeEstado = "Datos cargados correctamente.";
            }
            catch (Exception ex)
            {
                MensajeEstado = $"Error al cargar los datos: {ex.Message}";
            }
        }
    }
}