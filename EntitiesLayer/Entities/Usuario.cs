namespace EntitiesLayer.Entities
{
    public class Usuario
    {
        public int CodUsuario { get; set; }
        public int CodTrabajador { get; set; }
        public int CodRol { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int Estado { get; set; }
        public Trabajador Trabajador { get; set; }
        public Rol Rol { get; set; }
    }
}