using Refit;
using CallR.Models;

namespace CallR.Data
{
    public interface IWebAPI
    {
        [Get("")]
        Task<APIList1> GetAPI(); 
    }
}
