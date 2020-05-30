using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Dto.Repositories
{
    public class Error
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public Error(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
