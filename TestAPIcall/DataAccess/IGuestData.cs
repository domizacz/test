

using Refit;
using TestAPIcall.Models;

namespace TestAPIcall.DataAccess
{
    public interface IGuestData
    {
        [Get("/Guests")]
        Task<List<GuestModel>> GetGuest();

        [Get("/Guests/{id}")]
        Task<GuestModel> GetGuest(int id);

        [Post("/Guests")]
        Task CreateGuest([Body] GuestModel guest);

        [Put("/Guests/{id}")]
        Task UpdateGuest(int id, [Body] GuestModel guest);

        [Delete("/Guests/{id}")]
        Task DeleteGuest(int id);
    }
}
