

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

        [Post("/Guest")]
        Task CreateGuest([Body] GuestModel guest);

        [Put("/Guest/{id}")]
        Task UpdateGuest(int id, [Body] GuestModel guest);

        [Delete("/Guest/{id}")]
        Task DeleteGuest(int id);
    }
}
