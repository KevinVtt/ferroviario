


namespace Model
{
    public class Tren
    {

        private int idTren;
        private string descripcion;
        private string tipo;
        private int cantVagones;
        private decimal longitudMts;
        private string idGps;

        public Tren()
        {
        }

        public Tren(int idTren, string descripcion, string tipo, int cantVagones, decimal longitudMts, string idGps)
        {
            this.IdTren = idTren;
            this.Descripcion = descripcion;
            this.Tipo = tipo;
            this.CantVagones = cantVagones;
            this.LongitudMts = longitudMts;
            this.IdGps = idGps;
        }

        public int IdTren { get => idTren; set => idTren = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int CantVagones { get => cantVagones; set => cantVagones = value; }
        public decimal LongitudMts { get => longitudMts; set => longitudMts = value; }
        public string IdGps { get => idGps; set => idGps = value; }

        public override string ToString()
        {
            return $"{{{nameof(IdTren)}={IdTren.ToString()}, {nameof(Descripcion)}={Descripcion}, {nameof(Tipo)}={Tipo}, {nameof(CantVagones)}={CantVagones.ToString()}, {nameof(LongitudMts)}={LongitudMts.ToString()}, {nameof(IdGps)}={IdGps}}}";
        }
    }
}
