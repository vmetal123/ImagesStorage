using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Interfaces
{
    public interface IOutputPort<in TUseCaseResponse>
    {
        void Handle(TUseCaseResponse response);
    }
}
