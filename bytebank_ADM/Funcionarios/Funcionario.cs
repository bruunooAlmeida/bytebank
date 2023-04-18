using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public static int TotalFuncionarios { get; set; }
        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public double Salario { get; private set; }

        public Funcionario(String nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;

            TotalFuncionarios++;
        }


        /// <summary>
        /// Este método retorna 10% do salario do Funcionario

        /// </summary>
        /// <returns>this.salario.</returns>
        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }

        public virtual void MostrarInformacao()
        {
            Console.WriteLine("Nome...:" + this.Nome + '\n' +
                              "CPF....:" + this.Cpf + '\n' +
                              "Salario:" + this.Salario);
        }
    }
}
