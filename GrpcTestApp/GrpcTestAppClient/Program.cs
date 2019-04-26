using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Grpc.Core;
using static Messages.EmployeeService;
using System.IO;
using Messages;
using Google.Protobuf;

namespace GrpcTestAppClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            try
            {
                var option = int.Parse(args[0]);
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

                var empClient = new EmployeeServiceClient(channel);
                switch (option)
                {
                    case 1:
                        GetByBadgeNumberAsync(empClient).Wait();  //unary call
                        break;
                    case 2:
                        GetAllAsync(empClient).Wait(); //server streaming call
                        break;
                    case 3:
                        AddPhotoAsync(empClient).Wait();  //client streaming call
                        break;
                    case 4:
                        SaveAllAsync(empClient).Wait();   //bidirectional call
                        break;
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

        public static async Task SaveAllAsync(EmployeeServiceClient client)
        {
            var employees = new List<Employee> {
                new Employee
                {
                    Id=200,
                    BadgeNumber=200,
                    Firstname="Tom",
                    Lastname="Hardy"
                },
                new Employee
                {
                    Id=201,
                    BadgeNumber=201,
                    Firstname="John",
                    Lastname="Doy"
                },
            };

            using (var call = client.SaveAll())
            {
                var requestStream = call.RequestStream;
                var responseStream = call.ResponseStream;

                var responseTask = Task.Run(async () =>
                  {
                      while (await responseStream.MoveNext())
                      {
                          Console.WriteLine($"Saved : {responseStream.Current.Employee}");
                      }
                  });

                foreach (var e in employees)
                {
                    await requestStream.WriteAsync(new EmpoleeRequest() { Employee = e });
                }

                await call.RequestStream.CompleteAsync();
                await responseTask;
            }
        }

        public static async Task AddPhotoAsync(EmployeeServiceClient client)
        {
            Metadata md = new Metadata();
            md.Add("badgenumber", "1");

            FileStream stream = File.OpenRead(@"pic.jpg");
            using (var call = client.AddPhoto(md))
            {
                var requestStream = call.RequestStream;
                while (true)
                {
                    byte[] buff = new byte[64 * 1024];
                    int numRead = await stream.ReadAsync(buff, 0, buff.Length);
                    if (numRead == 0)
                        break;
                    if (numRead < buff.Length)
                        Array.Resize(ref buff, numRead);

                    await requestStream.WriteAsync(new AddPhotoRequest() { Data = ByteString.CopyFrom(buff) });
                }

                await requestStream.CompleteAsync();

                var res = await call.ResponseAsync;

                Console.WriteLine(res.IsOk);

            }
        }
        public static async Task GetByBadgeNumberAsync(EmployeeServiceClient client)
        {
            Metadata md = new Metadata();
            md.Add("username", "meri");
            try
            {
                var response = await client.GetByBadgeNumberAsync(new Messages.GetByBadgeNumberRequest { BadgeNumber = 1 }, md);
                Console.WriteLine(response.Employee);
            }
            catch
            {

            }
        }

        public static async Task GetAllAsync(EmployeeServiceClient client)
        {
            Metadata md = new Metadata();
            md.Add("username", "meri");
            try
            {
                using (var call = client.GetAll(new Messages.GetAllRequest(), md))
                {
                    var responseStream = call.ResponseStream;
                    while (await responseStream.MoveNext())
                    {
                        Console.WriteLine(responseStream.Current.Employee);
                    }
                }
            }
            catch
            {

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
