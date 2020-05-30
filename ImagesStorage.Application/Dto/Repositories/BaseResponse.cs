using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Dto.Repositories
{
    public abstract class BaseResponse
    {
        public bool Success { get; set; }
        public IEnumerable<Error> Errors { get; set; }

        protected BaseResponse(bool success = false, IEnumerable<Error> errors = null)
        {
            Success = success;
            Errors = errors;
        }
    }
}
