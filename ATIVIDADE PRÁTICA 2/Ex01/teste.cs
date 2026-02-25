using System;

internal class Teste
{
    static void Main(string[] args)
    {
        Estacionamento novoEstacionamento = new Estacionamento("Meu Estacionamento");
        /*int op;
        string placa = null;

        do
        {
            Console.WriteLine("*** MENU ****");
            Console.WriteLine("1 - Estacionar;");
            Console.WriteLine("2 - Buscar;");
            Console.WriteLine("3 - Retirar;");
            Console.WriteLine("4 - Exibir ocupação;");
            Console.WriteLine("5 - Exibir vagas livres;");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("Selecione a opção desejada: \n");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Digite a placa do veículo que deseja estacionar: ");
                    placa = Console.ReadLine();

                    int estaciona = novoEstacionamento.Estacionar(placa);
                    if( estaciona != -1)
                    {
                        Console.WriteLine("Estacionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Estacionamento cheio");
                    }
                    break;

                case 2:
                    Console.WriteLine("Digite a placa do veículo que deseja buscar: ");
                    placa = Console.ReadLine();

                    int busca = novoEstacionamento.BuscarNumVaga(placa);
                    if( busca != -1)
                    {
                        Console.WriteLine("O carro buscado está na vaga "+ busca);
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível encontrar o veículo.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Digite a placa do veículo que deseja buscar: ");
                    placa = Console.ReadLine();
                    novoEstacionamento.Retirar(placa);
                    break;

                case 4:
                    novoEstacionamento.ExibirOcupacao();
                    break;

                case 5:
                    int vagasDisponiveis = novoEstacionamento.NumVagasLivres;
                    Console.WriteLine(vagasDisponiveis);
                    break;

                case 6:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }while (op != 6);*/

        novoEstacionamento.Estacionar("ABC1");
        novoEstacionamento.Estacionar("ABC2");
        novoEstacionamento.Estacionar("ABC3");
        novoEstacionamento.Estacionar("ABC4");
        novoEstacionamento.Estacionar("ABC5");
        novoEstacionamento.ExibirOcupacao();
        novoEstacionamento.BuscarNumVaga("ABC3");
        novoEstacionamento.Retirar("ABC4");
        novoEstacionamento.ExibirOcupacao();
        novoEstacionamento.Estacionar("ABC6");
        novoEstacionamento.Estacionar("ABC7");
        novoEstacionamento.Estacionar("ABC8");
        novoEstacionamento.ExibirOcupacao();
        int vagasDisponiveis = novoEstacionamento.NumVagasLivres;
        Console.WriteLine(vagasDisponiveis);

    }
}
