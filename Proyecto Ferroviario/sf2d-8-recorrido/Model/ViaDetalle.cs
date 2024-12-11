using System.Collections;

namespace Model
{

	public class ViaDetalle
	{
		private int id;
		private Via via;
		private string nroOrden;
		private string rutaImagen;
		private decimal latitud;
		private decimal longitud;
		private Bobina bobina;
		private Semaforo semaforo;
		private Canton canton;
		private CambioVia cambioVia;
		private int altura;
		private Tren tren;
		private Hashtable coordenadas;
		private string rutaImagenSuperior;

        public ViaDetalle()
        {
        }

        public ViaDetalle(int id, Via via, string nroOrden, string rutaImagen, decimal latitud, decimal longitud, Bobina bobina, Semaforo semaforo, Canton canton, CambioVia cambioVia, int altura, Tren tren, string rutaImagenSuperior)
        {
            this.id = id;
            this.via = via;
            this.nroOrden = nroOrden;
            this.rutaImagen = rutaImagen;
            this.latitud = latitud;
            this.longitud = longitud;
            this.bobina = bobina;
            this.semaforo = semaforo;
            this.canton = canton;
            this.cambioVia = cambioVia;
            this.altura = altura;
            this.tren = tren;
            this.coordenadas = new Hashtable();
            this.rutaImagenSuperior = rutaImagenSuperior;
        }

        public int Id { get => id; set => id = value; }
        public Via Via { get => via; set => via = value; }
        public string NroOrden { get => nroOrden; set => nroOrden = value; }
        public string RutaImagen { get => rutaImagen; set => rutaImagen = value; }
        public decimal Latitud { get => latitud; set => latitud = value; }
        public decimal Longitud { get => longitud; set => longitud = value; }
        public Bobina Bobina { get => bobina; set => bobina = value; }
        public Semaforo Semaforo { get => semaforo; set => semaforo = value; }
        public Canton Canton { get => canton; set => canton = value; }
        public CambioVia CambioVia { get => cambioVia; set => cambioVia = value; }
        public int Altura { get => altura; set => altura = value; }
        public Tren Tren { get => tren; set => tren = value; }
        public Hashtable Coordenadas { get => coordenadas; set => coordenadas = value; }
        public string RutaImagenSuperior { get => rutaImagenSuperior; set => rutaImagenSuperior = value; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Via)}={Via}, {nameof(NroOrden)}={NroOrden}, {nameof(RutaImagen)}={RutaImagen}, {nameof(Latitud)}={Latitud.ToString()}, {nameof(Longitud)}={Longitud.ToString()}, {nameof(Bobina)}={Bobina}, {nameof(Semaforo)}={Semaforo}, {nameof(Canton)}={Canton}, {nameof(CambioVia)}={CambioVia}, {nameof(Altura)}={Altura.ToString()}, {nameof(Tren)}={Tren}, {nameof(Coordenadas)}={Coordenadas}, {nameof(RutaImagenSuperior)}={RutaImagenSuperior}}}";
        }
    }
}
