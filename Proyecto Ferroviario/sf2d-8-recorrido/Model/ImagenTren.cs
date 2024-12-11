


namespace Model
{
    public class ImagenTren
    {
        private Tren tren;
        private byte[] imagen1;
        private byte[] imagen2;
        private byte[] imagen3;
        private byte[] imagen4;
        private byte[] imagen5;
        private byte[] imagen6;
        private byte[] imagenArriba;

        public ImagenTren(Tren tren, byte[] imagen1, byte[] imagen2, byte[] imagen3, byte[] imagen4, byte[] imagen5, byte[] imagen6, byte[] imagenArriba)
        {
            this.tren = tren;
            this.imagen1 = imagen1;
            this.imagen2 = imagen2;
            this.imagen3 = imagen3;
            this.imagen4 = imagen4;
            this.imagen5 = imagen5;
            this.imagen6 = imagen6;
            this.imagenArriba = imagenArriba;
        }

        public Tren Tren { get => tren; set => tren = value; }
        public byte[] Imagen1 { get => imagen1; set => imagen1 = value; }
        public byte[] Imagen2 { get => imagen2; set => imagen2 = value; }
        public byte[] Imagen3 { get => imagen3; set => imagen3 = value; }
        public byte[] Imagen4 { get => imagen4; set => imagen4 = value; }
        public byte[] Imagen5 { get => imagen5; set => imagen5 = value; }
        public byte[] Imagen6 { get => imagen6; set => imagen6 = value; }
        public byte[] ImagenArriba { get => imagenArriba; set => imagenArriba = value; }

        public override string ToString()
        {
            return $"{{{nameof(Tren)}={Tren}, {nameof(Imagen1)}={Imagen1}, {nameof(Imagen2)}={Imagen2}, {nameof(Imagen3)}={Imagen3}, {nameof(Imagen4)}={Imagen4}, {nameof(Imagen5)}={Imagen5}, {nameof(Imagen6)}={Imagen6}, {nameof(ImagenArriba)}={ImagenArriba}}}";
        }
    }
}
