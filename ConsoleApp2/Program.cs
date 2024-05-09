using System;
using System.IO;

class Program
{
    static void Main()
    {
        string nomeRestaurante = "Restaurante Exemplo";
        string[] pedidos = { "Pizza de Calabresa", "Refrigerante", "Sobremesa de Chocolate" };
        int[] quantidades = { 2, 3, 1 }; 

        string comanda = "+" + new string('-', 40) + "+\n";
        comanda += $"|{"Restaurante: Comida Gaúcha ",-40}|\n";
        comanda += $"|{"Comanda: 25",-40}|\n";
        comanda += "+" + new string('-', 40) + "+\n";

        comanda += $"|{"Data: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),-40}|\n";
        comanda += $"|{"Entrega prevista: " + DateTime.Now.AddHours(1).ToString("dd/MM/yyy HH:mm:ss"),-40}|\n";

        comanda += "+" + new string('-', 40) + "+\n";

        comanda += $"|{"Mesa: 4 ",-40}|\n";
        comanda += $"|{"Garçom: Julio Cesas ",-40}|\n";
        comanda += $"|{"Observação: Sem picles ",-40}|\n";

        comanda += "+" + new string('-', 40) + "+\n";

        comanda += "| Qtd | Item                             |\n";
        for (int i = 0; i < pedidos.Length; i++)
        {
            comanda += $"| {quantidades[i],-3} | {pedidos[i],-32} |\n";
        }
        comanda += "+" + new string('-', 40) + "+\n";
        comanda += $"|{"4Tables Company.",-40}|\n";
        comanda += "+" + new string('-', 40) + "+\n";

        string diretorio = @"C:\Users\pedro.guarnieri\source\repos\ConsoleApp2"; 

        // Salvar a comanda em um arquivo
        string nomeArquivo = "comanda.txt";
        string caminhoCompleto = Path.Combine(diretorio, nomeArquivo);
        File.WriteAllText(caminhoCompleto, comanda);

        Console.WriteLine($"Comanda salva em: {caminhoCompleto}");
        Console.WriteLine("Por favor, abra o arquivo manualmente para visualizá-lo.");
    }
}
