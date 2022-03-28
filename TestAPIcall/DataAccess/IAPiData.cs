using Refit;
using TestAPIcall.Models;

namespace TestAPIcall.DataAccess
{
    public interface IAPiData
    {
        [Get("/entries")]
        Task<List<APIGet>> GetAPI();
    }
}
