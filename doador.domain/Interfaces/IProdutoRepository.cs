using doador.domain.Comamands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doador.domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<string> PostAsync(ProdutoCommand command);
        void PostAsync();
        void GetAsync();
        //Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveis();
        //Task<VeiculoPrecoCommand> GetPrecoDiaria(ETipoVeiculo tipoVeiculo);
        //Task<bool> VeiculoEstaAlugado(string placaVeiculo);
    }
}
