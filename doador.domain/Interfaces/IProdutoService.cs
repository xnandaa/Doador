using doador.domain.Comamands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doador.domain.Interfaces
{
    public interface IProdutoService 
    { 

         Task<string> PostAsync(ProdutoCommand command);
        void PostAsync();
       void GetAsync();
       //Task<IEnumerable<ProdutoCommand>> GetVeiculosDisponiveis();
      //Task<SimularVeiculoAluguelViewModel> SimularVeiculoAluguel(int TotalDiasSimulado, ETipoVeiculo tipoVeiculo);

       //Task AlugarVeiculo(AlugarVeiculoViewModelInput input);
    
    }
}
