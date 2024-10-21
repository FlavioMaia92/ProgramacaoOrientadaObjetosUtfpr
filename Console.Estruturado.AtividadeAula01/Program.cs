using System;

class Program
{
    static void Main(string[] args)
    {
        int votosA = 0, votosB = 0;
        bool votacaoAtiva = true;

        while (votacaoAtiva)
        {
            Console.WriteLine("Vote no candidato: 1. Candidato A | 2. Candidato B | 0. Encerrar votação");
            string escolha = Console.ReadLine();

            if (escolha == "1") votosA++;
            else if (escolha == "2") votosB++;
            else if (escolha == "0") votacaoAtiva = false;
            else Console.WriteLine("Opção inválida.");
        }

        Console.WriteLine($"\nResultado da votação:\nCandidato A: {votosA} votos\nCandidato B: {votosB} votos");
        Console.WriteLine(votosA > votosB ? "Candidato A venceu!" : votosB > votosA ? "Candidato B venceu!" : "Empate!");
    }
}
