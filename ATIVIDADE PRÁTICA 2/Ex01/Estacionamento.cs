using System;

internal class Estacionamento
{
    private string nome;
    private int numVagasLivres;
    private string[] vagas;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int NumVagasLivres
    {
        get { return numVagasLivres; }
    }

   public Estacionamento(string nome)
   {
        this.nome = nome;
        numVagasLivres = 10;
        vagas = new string[numVagasLivres];
   }

    public int Estacionar(string placa)
    {
        for(int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i] == null)
            {
                vagas[i] = placa;
                numVagasLivres--;
                return i;
            }
         }
        return -1;
    }

    public int BuscarNumVaga(string placa)
    {
        for (int i = 0;i < vagas.Length;i++)
        {
            if (vagas[i] != null && vagas[i] == placa)
            {
                return i;
            }
        }
        return -1;
    }

    public void Retirar(string placa)
    {
        for(int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i] != null && vagas[i] == placa)
            {
                vagas[i] = null;
                numVagasLivres++;
                Console.WriteLine("Vaga retirada com sucesso!");
                break;
            }
        }
    }
        
    public void ExibirOcupacao()
    {
        for(int i = 0 ; i < vagas.Length ; i++)
        {
            Console.Write("Vaga "+ i + " | ");
            if (vagas[i] == null)
            {
                Console.WriteLine("Vaga vazia");
            }
            else
            {
                Console.WriteLine($"Placa do veículo estacionado: {vagas[i]}");
            }
        }
    }

}
