using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Interfaces
{
    public abstract class UseCaseResponseMessage
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        protected UseCaseResponseMessage(bool success = false, string message = null)
        {
            Success = success;
            Message = message;
        }
    }
}
