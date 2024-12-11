

namespace Model
{
    public class Ramal
    {

        private int idRamal;
        private Linea linea;
        private string nombreRamal;

        public Ramal()
        {
        }

        public Ramal(int idRamal, Linea linea, string nombreRamal)
        {
            this.idRamal = idRamal;
            this.linea = linea;
            this.nombreRamal = nombreRamal;
        }

        public int IdRamal { get => idRamal; set => idRamal = value; }
        public Linea Linea { get => linea; set => linea = value; }
        public string NombreRamal { get => nombreRamal; set => nombreRamal = value; }

        public override string ToString()
        {
            return $"{{{nameof(IdRamal)}={IdRamal.ToString()}, {nameof(Linea)}={Linea}, {nameof(NombreRamal)}={NombreRamal}}}";
        }
    }
}
