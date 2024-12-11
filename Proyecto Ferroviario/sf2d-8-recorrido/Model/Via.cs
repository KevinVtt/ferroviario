

namespace Model
{
    public class Via
    {

        private int idVia;
        private Ramal ramal;
        private string nombreVia;

        public Via(int idVia, Ramal ramal, string nombreVia)
        {
            this.idVia = idVia;
            this.ramal = ramal;
            this.nombreVia = nombreVia;
        }

        public int IdVia { get => idVia; set => idVia = value; }
        public Ramal Ramal { get => ramal; set => ramal = value; }
        public string NombreVia { get => nombreVia; set => nombreVia = value; }

        public override string ToString()
        {
            return $"{{{nameof(IdVia)}={IdVia.ToString()}, {nameof(Ramal)}={Ramal}, {nameof(NombreVia)}={NombreVia}}}";
        }
    }
}
