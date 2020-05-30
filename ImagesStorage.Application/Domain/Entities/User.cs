using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Domain.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }

        internal User(string firstname, string lastname, string email, string username,string id = null, string hashedPassword = null)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Username = username;
            HashedPassword = hashedPassword;
        }
    }
}
