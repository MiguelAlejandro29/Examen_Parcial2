namespace DatosMysql.Entidades
{
    public class Productos
    {
        public string CodigoP { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Productos()
        {
        }

        public Productos(string codigoP, string descripcion, decimal precio)
        {
            CodigoP = codigoP;
            Descripcion = descripcion;
            Precio = precio;
        }
    }


}
