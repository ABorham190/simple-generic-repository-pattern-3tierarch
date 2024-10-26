namespace simple_api_generic_repo.DAL.Data.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int DepartmentID { get; set; }
        public decimal Salary { get; set; }
    }


}
