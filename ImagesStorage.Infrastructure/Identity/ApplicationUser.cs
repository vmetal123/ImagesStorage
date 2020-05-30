using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Infrastructure.Identity
{
    [CollectionName("Users")]
    public class ApplicationUser: MongoIdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
