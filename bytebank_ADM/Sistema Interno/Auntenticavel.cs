using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Sistema_Interno
{
    public class Auntenticavel : Funcionario
    {
        public string senha { get; set; }

        public Auntenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }

        public Auntenticavel (string cpf): base(cpf) { }

        public bool Autenicar(string senha)
        {
            return senha == this.Senha;
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
