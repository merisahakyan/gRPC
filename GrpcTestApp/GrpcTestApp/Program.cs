using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcTestApp.Controllers;
using Messages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GrpcTestApp
{
    public class Program
    {
        const int Port = 50051;
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            try
            {
                Server server = new Server
                {
                    Services = { AccountService.BindService(new AccountsGrpc()),
                                   EmployeeService.BindService(new EmployeeGrpc())},
                    Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
                };
                server.Start();

                Console.WriteLine("Server listening on port " + Port);
                Console.WriteLine("Press any key to stop the server...");
                Console.ReadKey();

                server.ShutdownAsync().Wait();
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
