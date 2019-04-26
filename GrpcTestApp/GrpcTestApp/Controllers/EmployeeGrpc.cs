using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcTestApp.Data;
using Messages;
using static Messages.EmployeeService;

namespace GrpcTestApp.Controllers
{
    public class EmployeeGrpc : EmployeeServiceBase
    {
        public override Task<EmpoleeResponse> GetByBadgeNumber(GetByBadgeNumberRequest request, ServerCallContext context)
        {
            return Task.FromResult(new EmpoleeResponse { Employee = EmployeesData.employees.FirstOrDefault(e => e.BadgeNumber == request.BadgeNumber) });
        }

        public override async Task GetAll(GetAllRequest request, IServerStreamWriter<EmpoleeResponse> responseStream, ServerCallContext context)
        {
            foreach (var e in EmployeesData.employees)
            {
                await responseStream.WriteAsync(new EmpoleeResponse { Employee = e });
            }
        }

        public override async Task<AddPhotoResponse> AddPhoto(IAsyncStreamReader<AddPhotoRequest> requestStream, ServerCallContext context)
        {
            Metadata md = context.RequestHeaders;
            foreach (var entry in md)
            {
                if (entry.Key.Equals("badgenumber", StringComparison.CurrentCulture))
                {
                    Console.WriteLine($"Badgenumber : {entry.Value}");
                    break;
                }
            }

            var data = new List<byte>();
            while (await requestStream.MoveNext())
            {
                Console.WriteLine($"Recived : {requestStream.Current.Data.Length} bytes");
                data.AddRange(requestStream.Current.Data);
            }
            Console.WriteLine($"Recived file with {data.Count} bytes");

            return new AddPhotoResponse
            {
                IsOk = true
            };
        }

        public override async Task SaveAll(IAsyncStreamReader<EmpoleeRequest> requestStream, IServerStreamWriter<EmpoleeResponse> responseStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext())
            {
                var employee = requestStream.Current.Employee;
                lock (this)
                {
                    EmployeesData.employees.Add(employee);
                }

                await responseStream.WriteAsync(new EmpoleeResponse { Employee = employee });
            }

            Console.WriteLine("Employees");
            foreach (var e in EmployeesData.employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
