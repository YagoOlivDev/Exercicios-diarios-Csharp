using ConsoleApp1;

Console.WriteLine("Digite o numero da conta: ");
int numeroConta = int.Parse(Console.ReadLine());

Console.WriteLine("Digite Titular da Conta: ");
string nomeTitular = Console.ReadLine();

Conta conta1 = new Conta(nomeTitular, numeroConta);

Console.WriteLine("Haverá depósito inicial? S/N ");
string opcao1 = Console.ReadLine().ToUpper();

if (opcao1 == "S")
{
    Console.WriteLine("Digite o valor de deposito inicial");
    double deposito = double.Parse(Console.ReadLine());
    conta1.Depositar(deposito);
}

conta1.DadosConta();

conta1.Sacar(500);

conta1.DadosConta();
