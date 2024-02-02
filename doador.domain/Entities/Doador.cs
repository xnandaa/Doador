using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doador.domain.Entities
{
    public class Doador
    {
        public Doador()
        {
            
        }
        public int DoadorId { get; set; }
        public string DoadorNome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        
             
       



    }


    


}
