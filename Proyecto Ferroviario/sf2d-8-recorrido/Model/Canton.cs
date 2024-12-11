

namespace Model {
    public class Canton
    {
        private int idCanton;
        private int nro;
        private byte bloquea;
        private byte bloqueado;

        public Canton()
        {
        }

        public Canton(int idCanton, int nro, byte bloquea, byte bloqueado)
        {
            this.idCanton = idCanton;
            this.nro = nro;
            this.bloquea = bloquea;
            this.bloqueado = bloqueado;
        }

        public int IdCanton { get => idCanton; set => idCanton = value; }
        public int Nro { get => nro; set => nro = value; }
        public byte Bloquea { get => bloquea; set => bloquea = value; }
        public byte Bloqueado { get => bloqueado; set => bloqueado = value; }

        public override string ToString()
        {
            return $"{{{nameof(IdCanton)}={IdCanton.ToString()}, {nameof(Nro)}={Nro.ToString()}, {nameof(Bloquea)}={Bloquea.ToString()}, {nameof(Bloqueado)}={Bloqueado.ToString()}}}";
        }
    }

}