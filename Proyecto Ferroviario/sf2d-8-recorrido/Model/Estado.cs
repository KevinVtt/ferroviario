

namespace Model
{
    public class Estado
    {

        private Semaforo Semaforo;
        private string estadoSem;

        public Estado()
        {
        }

        public Estado(Semaforo semaforo, string estado)
        {
            Semaforo = semaforo;
            this.estadoSem = estado;
        }

        public Semaforo Semaforo1 { get => Semaforo; set => Semaforo = value; }
        public string EstadoSem { get => estadoSem; set => estadoSem = value; }

        public override string? ToString()
        {
            return "Semaforo: " + Semaforo + " Estado: " + estadoSem; 
        }
    }
}
