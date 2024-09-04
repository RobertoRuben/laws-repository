namespace EntitiesLayer.Entities
{
    public class Employee
    {
        public int CodEmployee { set; get; }
        public int Dni { set; get; }
        public string EmployeeName { set; get; }
        public string PaternalSurname { get; set; }
        public string MaternalSurname { get; set; }
        public char Gender { get; set; }
    }
}