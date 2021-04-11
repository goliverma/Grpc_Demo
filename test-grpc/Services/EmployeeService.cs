using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using test_grpc.Data.Repository;
using test_models.Tables;

namespace test_grpc.Services
{
    public class EmployeeService : EmployeeGreeter.EmployeeGreeterBase
    {
        private readonly IEmployeeRepo con;

        public EmployeeService(IEmployeeRepo con)
        {
            this.con = con;
        }
        public async override Task<replyemp> getemploye(responseemp emp, ServerCallContext context)
        {
            var employee = await con.GetEmployee(emp.EmployeeId);
            return await Task.FromResult(new replyemp{
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Address = employee.Address
            });
        }
        public override async Task<replyemps> getemployes(Empty empty, ServerCallContext context)
        {
            var employee = await con.GetEmployees();
            replyemps emp = new replyemps();
            foreach (var item in employee)
            {
                emp.Replyempss.Add(new replyemp{EmployeeId=item.EmployeeId, FirstName=item.FirstName, LastName=item.LastName, Email=item.Email, Address=item.Address});
            }
            return await Task.FromResult(emp);
        }
        public override async Task<replyemp> updateemploye(replyemp emp, ServerCallContext context)
        {
            var data = new Employee{
                EmployeeId = emp.EmployeeId,
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                Email = emp.Email,
                Address = emp.Address
            };
            var data1 = await con.UpdateEmployee(data);
            return await Task.FromResult(new replyemp{
                EmployeeId = data1.EmployeeId,
                FirstName = data1.FirstName,
                LastName = data1.LastName,
                Email = data1.Email,
                Address = data1.Address
            });
        }
    }
}