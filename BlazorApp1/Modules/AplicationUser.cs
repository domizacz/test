using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace BlazorApp1.Modules
{
    [CollectionName("Users")]
    public class AplicationUser:MongoIdentityUser <Guid>
    {

    }
}
