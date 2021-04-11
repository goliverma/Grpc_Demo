using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using test_grpc;
using test_models.Tables;

namespace test_blazor.Data.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeGreeter.EmployeeGreeterClient client;

        public EmployeeRepo()
        {
            var channel = GrpcChannel.ForAddress("http://localhost:5000");
            client = new EmployeeGreeter.EmployeeGreeterClient(channel);
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var data = await client.getemployeAsync(new responseemp{EmployeeId=id});
            Employee emp = new Employee{
                EmployeeId = data.EmployeeId,
                FirstName = data.FirstName,
                LastName = data.LastName,
                Email = data.Email,
                Address = data.Address
            };
            return emp;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var data = await client.getemployesAsync(new Empty{});
            List<Employee> emp = new List<Employee>();
            foreach (var item in data.Replyempss)
            {
                emp.Add(new Employee{EmployeeId=item.EmployeeId, FirstName=item.FirstName, LastName=item.LastName, Email=item.Email, Address=item.Address});
            }
            return emp;
        }
    }
}