using doador.domain.Comamands;
using doador.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doador.service.Service
{
    public class DoadorService : IDoadorService
    {
        private readonly IDoadorRepository _repository;
        public DoadorService(IDoadorRepository doadorRepository)
        {
            _repository = doadorRepository;
        }

        public Task GetAsync(DoadorCommand command)
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(DoadorCommand command)
        {
            return await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
}   }
        
