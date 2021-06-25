using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamuraiBlazor.Domain
{
    interface ISamuraiService
    {
        Task<IEnumerable<Samurai>> GetSamrai();
    }
}
