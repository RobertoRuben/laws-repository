namespace EntitiesLayer.Entities
{
    public class Norma
    {
        public int CodNormatividad { set; get; }
        public int CodUsuario { set; get; }
        public int CodTipoNorma { set; get; }
        public string NumeroNorma { set; get; }
        public string NombreNorma { set; get; }
        public string Resumen { set; get; }
        public string FechaPublicacion { set; get; }
        public int CantidadDePaginas { set; get; }
        public string MedioPublicacion { set; get; }
        public string LinkDocumento { set; get; }
        public string Estado { set; get; }
    }
}