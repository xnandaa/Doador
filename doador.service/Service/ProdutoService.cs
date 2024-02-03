using doador.domain.Comamands;
using doador.domain.Interfaces;

namespace doador.service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _repository = produtoRepository;
        }

        public Task GetAsync(ProdutoCommand command)
        {
            throw new NotImplementedException();
        }

        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(ProdutoCommand command)
        {
            return await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
