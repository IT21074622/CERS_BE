using System;
using System.Collections.Generic;
using System.Text;
using Employee.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Employee.Repository.Interfaces
{
    public interface IFeedbakRepository
    {
        Task<Response> Select(string Name);
        Task<Response> Insert(FeedbackModel feedback);
        Task<Response> Update(FeedbackModel feedback);
        Task<Response> Delete(string Name);
        void SetRequest(HttpRequest httpRequest);
    }
}
