namespace EntitiesLayer.Entities
{
    public class Usuario
    {
        public int CodUsuario { get; set; }
        public int CodTrabajador { get; set; }
        public int CodRol { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Estado { get; set; }
    }
}