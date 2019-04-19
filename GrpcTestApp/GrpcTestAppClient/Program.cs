using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Grpc.Core;

namespace GrpcTestAppClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            try
            {
                Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
                var client = new AccountService.AccountServiceClient(channel);
                EmployeeName empName = client.GetEmployeeName(new EmployeeNameRequest { EmpId = "1" });

                if (empName == null || string.IsNullOrWhiteSpace(empName.FirstName) || string.IsNullOrWhiteSpace(empName.LastName))
                {
                    Console.WriteLine("Employee not found.");
                }
                else
                {
                    Console.WriteLine($"The employee name is {empName.FirstName} {empName.LastName}.");
                }
                channel.ShutdownAsync().Wait();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception encountered: {ex}");
            }
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
