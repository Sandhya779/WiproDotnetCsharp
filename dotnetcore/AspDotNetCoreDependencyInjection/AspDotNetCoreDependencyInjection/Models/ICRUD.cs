namespace AspDotNetCoreDependencyInjection.Models
{
    public interface ICRUD
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployeeById(int id);
        void Create(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}
