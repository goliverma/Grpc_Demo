using System.Collections.Generic;
using System.Threading.Tasks;
using test_models.Tables;

namespace test_blazor.Data.Repository
{
    public interface IEmployeeRepo
    {
        Task<Employee> GetEmployee(int id);
        Task<IEnumerable<Employee>> GetEmployees();
    }
}