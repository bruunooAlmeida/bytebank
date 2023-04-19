using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bytebank_ADM.SistemaInterno.SistemaInterno;

namespace bytebank_ADM.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        
        public ParceiroComercial(string senha) { }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
