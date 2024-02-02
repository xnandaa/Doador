using doador.domain.Comamands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doador.domain.Interfaces
{
    public interface IDoadorService
    {
        Task<string> PostAsync(DoadorCommand command);
        Task GetAsync(DoadorCommand command);
    }
}
