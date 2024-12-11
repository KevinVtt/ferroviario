

namespace Model
{
    public class Semaforo
    {

        private int idSemaforo;
        private int nro;
        private Estado estado;
        private decimal latitud;
        private decimal longitud;
        private decimal altura;

        public Semaforo(int idSemaforo, int nro, Estado estado, decimal latitud, decimal longitud, decimal altura)
        {
            this.idSemaforo = idSemaforo;
            this.nro = nro;
            this.estado = estado;
            this.latitud = latitud;
            this.longitud = longitud;
            this.altura = altura;
        }

        public int IdSemaforo { get => idSemaforo; set => idSemaforo = value; }
        public int Nro { get => nro; set => nro = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public decimal Latitud { get => latitud; set => latitud = value; }
        public decimal Longitud { get => longitud; set => longitud = value; }
        public decimal Altura { get => altura; set => altura = value; }

        public override string ToString()
        {
            return $"{{{nameof(IdSemaforo)}={IdSemaforo.ToString()}, {nameof(Nro)}={Nro.ToString()}, {nameof(Estado)}={Estado}, {nameof(Latitud)}={Latitud.ToString()}, {nameof(Longitud)}={Longitud.ToString()}, {nameof(Altura)}={Altura.ToString()}}}";
        }
    }
}


