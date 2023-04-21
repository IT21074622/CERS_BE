using System;
using System.Collections.Generic;
using System.Text;
using Employee.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Employee.Repository.Interfaces
{
    public interface IVehicleRepository
    {
        Task<Response> Select(string VehicleID);
        Task<Response> Insert(VehicleClass vehicle);
        Task<Response> Update(VehicleClass vehicle);
        Task<Response> Delete(string VehicleID);
        void SetRequest(HttpRequest httpRequest);
    }
}
