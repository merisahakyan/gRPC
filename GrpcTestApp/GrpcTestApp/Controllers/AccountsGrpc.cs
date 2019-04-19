using Grpc.Core;
using GrpcTestApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcTestApp.Controllers
{
    public class AccountsGrpc : AccountService.AccountServiceBase
    {
        // Server side handler of the GetEmployeeName RPCpublic 
        public override Task<EmployeeName> GetEmployeeName(EmployeeNameRequest request, ServerCallContext context)
        {
            EmployeeData empData = new EmployeeData();
            return Task.FromResult(empData.GetEmployeeName(request));
        }
    }

}
