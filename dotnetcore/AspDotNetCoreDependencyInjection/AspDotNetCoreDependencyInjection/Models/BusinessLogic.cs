namespace AspDotNetCoreDependencyInjection.Models
{
    public class BusinessLogic : ICRUD
    {
        public string MyGuid { get; set; }
        public BusinessLogic()
        {
            this.MyGuid = Guid.NewGuid().ToString();
        }

        public void Create(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return null;
        }

        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}