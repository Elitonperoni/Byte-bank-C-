using byte_bank_ADM.Funcionarios;
using byte_bank_ADM.SistemaInterno;
using byte_bank_ADM.Utilitário;

#region
//Funcionario eliton = new Funcionario("123456789", 2000);

//eliton.Nome = "Eliton Peroni";

//Console.WriteLine("Nome: " + eliton.Nome);
//Console.WriteLine("Bonificação: " + eliton.GetBonificacao());

//Diretor roberta = new Diretor("12343211-21");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine("Nome: " + roberta.Nome);
//Console.WriteLine("Bonificação: " + roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(eliton);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);

//eliton.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salario do Eliton: " + eliton.Salario);
//Console.WriteLine("Novo salario da Roberta: " + roberta.Salario);
#endregion

//CalcularBonificacao();

UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("546237364-12");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("321758472-21");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("12312432-43");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("3123543345-34");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);

    Console.WriteLine("Toal de bonificação = " + gerenciador.TotalDeBonificacao);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("853234-34");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("123412312");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "3123";

    Auxiliar henrique = new Auxiliar("85238481283");
    henrique.Nome = "Henrique Carvalho";
    henrique.Senha = "852";

    Designer clovis = new Designer("9521752");
    clovis.Senha = "654";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "999");
    sistema.Logar(henrique, "852");




}


