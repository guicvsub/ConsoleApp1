// Projeto de Avaliação (Revisado) - Variante 3: Cálculo de média de três notas
// Este programa deve solicitar o nome do estudante e três notas, calcular e exibir a média.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do estudante:");
        //tipagem com erro 
        string nome = Console.ReadLine();
        double soma = 0;
        //aqui o zero conta entao tirei para ficar nota 1 , 2 , 3
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Digite a nota " + i + ":");
            //estava sem comversao
            double nota = double.Parse(Console.ReadLine());

            soma = soma + nota;
        }

        double media = soma / 3;
        //aqui vou interpolar pra ficar bonito 
        Console.WriteLine($" A média do estudante {nome}  é   {media}");
    }
}