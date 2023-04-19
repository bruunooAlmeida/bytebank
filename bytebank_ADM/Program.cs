using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.Sistema_Interno;
using bytebank_ADM.Utilitario;


//Funcionario funcionario = new Funcionario("Buno Henrique", "06518795905", 4500);
//Console.WriteLine("Total_Funcionarios" + Funcionario.TotalFuncionarios);
Diretor diretor = new Diretor(1, "bruno Silva", "06518795905");
Console.WriteLine("Total_Funcionarios:" + Funcionario.TotalFuncionarios);
GerenciadorDeBonificacao ger = new GerenciadorDeBonificacao();

//Console.WriteLine(funcionario.GetBonificacao());
//funcionario.MostrarInformacao();
//diretor.MostrarInformacao();

//ger.Registrar(funcionario);

ger.Registrar(diretor);

UsarSistema();

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();
    Diretor ingrid = new Diretor("8445455");    
    ingrid.Nome    = "Ingrid Novaes";
    ingrid.Senha   = "123456";


    GerenteDeConta ursula = new GerenteDeConta("946555");
    ursula.Senha = "12345";
    ursula.Nome = "Joaquina Silva";

    ParceiroComercial caio = new ParceiroComercial("999");

    sistema.Logar(caio, "999");

    sistema.Logar(ursula, "12345");
    sistema.Logar(ingrid, "12345");

}

//ger.MostrarTotal();

