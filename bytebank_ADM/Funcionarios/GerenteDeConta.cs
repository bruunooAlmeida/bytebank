using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        public GerenteDeConta( string cpf) : base (cpf) { }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
