

namespace Model
{
    public class CambioVia
    {

        private int idCambioVia;
        private int nro;
        private int idProximaImg;
        private int idProximaImg2;
        private int opcionCmb;

        public CambioVia()
        {
        }

        public CambioVia(int idCambioVia, int nro, int idProximaImg, int idProximaImg2, int opcionCmb)
        {
            this.idCambioVia = idCambioVia;
            this.nro = nro;
            this.idProximaImg = idProximaImg;
            this.idProximaImg2 = idProximaImg2;
            this.opcionCmb = opcionCmb;
        }

        public int IdCambioVia { get => idCambioVia; set => idCambioVia = value; }
        public int Nro { get => nro; set => nro = value; }
        public int IdProximaImg { get => idProximaImg; set => idProximaImg = value; }
        public int IdProximaImg2 { get => idProximaImg2; set => idProximaImg2 = value; }
        public int OpcionCmb { get => opcionCmb; set => opcionCmb = value; }

        public override string ToString()
        {
            return $"{{{nameof(IdCambioVia)}={IdCambioVia.ToString()}, {nameof(Nro)}={Nro.ToString()}, {nameof(IdProximaImg)}={IdProximaImg.ToString()}, {nameof(IdProximaImg2)}={IdProximaImg2.ToString()}, {nameof(OpcionCmb)}={OpcionCmb.ToString()}}}";
        }
    }
}
