using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test_models.Tables;

namespace test_grpc.Data.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly AppDbContext context;

        public EmployeeRepo(AppDbContext context)
        {
            this.context = context;
        }
        public async Task DeleteEmployee(int id)
        {
            var data = await GetEmployee(id);
            context.Remove(data);
            await context.SaveChangesAsync();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await context.Employees.ToListAsync();
        }

        public async Task PostEmployee(Employee employee)
        {
            await context.Employees.AddAsync(employee);
            await context.SaveChangesAsync();
        }

        public async Task UpdateEmployee(Employee changeemployee)
        {
            await Task.Run(async ()=>{
                var data1 = context.Employees.Attach(changeemployee);
                data1.State = EntityState.Modified;
                await context.SaveChangesAsync();
            });
        }
    }
}