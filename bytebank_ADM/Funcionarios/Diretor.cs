using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {


        public int nivel { get; set; }

        public Diretor(int nivel, String nome, string cpf, double salario) : base(nome, cpf, salario)
        {
            this.nivel = nivel;
        }
        /// <summary>
        /// Este método retorna 10% do salario do Funcionario

        /// </summary>
        /// <returns>this.salario.</returns>
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }

        public override void MostrarInformacao()
        {
            Console.WriteLine(".........Diretor........\n" +
                              "Nome...:" + this.Nome + '\n' +
                              "CPF....:" + this.Cpf + '\n' +
                              "Salario:" + this.Salario);
        }
    }
}
