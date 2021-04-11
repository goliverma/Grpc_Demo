using System;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using test_grpc;

namespace test_exe
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var channel = GrpcChannel.ForAddress("http://localhost:5000");
            var Client = new EmployeeGreeter.EmployeeGreeterClient(channel);
            var data = await Client.getemployeAsync(new responseemp{EmployeeId = 1});
            Console.WriteLine($"{data.EmployeeId}\n{data.FirstName}\n{data.LastName}\n{data.Email}\n{data.Address}\n");
            var data1 = await Client.getemployesAsync(new Empty{});
            foreach (var item in data1.Replyempss)
            {
                Console.WriteLine($"{item.EmployeeId}\n{item.FirstName}\n{item.LastName}\n{item.Email}\n{item.Address}\n\t\n\t\n");
            }
        }
    }
}
