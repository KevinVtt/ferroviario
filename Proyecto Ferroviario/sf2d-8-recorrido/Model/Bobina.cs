

namespace Model
{
    public class Bobina
    {
        private int idBobina;
        private int nro;

        public Bobina()
        {
        }

        public Bobina(int idBobina, int nro)
        {
            this.idBobina = idBobina;
            this.nro = nro;
        }

        public int IdBobina { get => idBobina; set => idBobina = value; }
        public int Nro { get => nro; set => nro = value; }

        public override string ToString()
        {
            return $"{{{nameof(IdBobina)}={IdBobina.ToString()}, {nameof(Nro)}={Nro.ToString()}}}";
        }
    }
}
