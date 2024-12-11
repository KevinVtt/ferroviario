

namespace Model
{
    public class Linea
    {

        private int idLinea;
        private string nombreLinea;

        public Linea()
        {
        }

        public Linea(int idLinea, string nombreLinea)
        {
            this.idLinea = idLinea;
            this.nombreLinea = nombreLinea;
        }

        public int IdLinea { get => idLinea; set => idLinea = value; }
        public string NombreLinea { get => nombreLinea; set => nombreLinea = value; }

        public override string ToString()
        {
            return $"{{{nameof(IdLinea)}={IdLinea.ToString()}, {nameof(NombreLinea)}={NombreLinea}}}";
        }
    }
}
