namespace EntitiesLayer.Entities
{
    public class Trabajador
    {
        public int CodTrabajador { set; get; }
        public int Dni { set; get; }
        public string Nombre { set; get; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public char Sexo { get; set; }
    }
}