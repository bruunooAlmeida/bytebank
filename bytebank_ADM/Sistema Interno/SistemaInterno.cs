using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Sistema_Interno
{
    public class SistemaInterno
    {
         public bool Logar(Funcionario funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenicar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Usuario Autenticado com Sucesso");

                return true;
            }else {
                Console.WriteLine("Senha Incorreta!");
                return false; 
            }
        }
    }
}
