using Refit;
using CallR.Models;

namespace CallR.Data
{
    public interface IWebAPI
    {
        [Get("/entries")]
        Task<APIList1> GetAPI(); 
    }
}
