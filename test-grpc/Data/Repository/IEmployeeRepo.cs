using System.Collections.Generic;
using System.Threading.Tasks;
using test_models.Tables;

namespace test_grpc.Data.Repository
{
    public interface IEmployeeRepo
    {
        Task<Employee> GetEmployee(int id);
        Task<IEnumerable<Employee>> GetEmployees();
        Task PostEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee changeemployee);
        Task DeleteEmployee(int id);
    }
}