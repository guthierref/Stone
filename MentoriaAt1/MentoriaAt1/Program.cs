using System;
public class Salarios
{
    public static void Main(string[] args)
    {
        string Pessoa;
        double Salario;
        Console.WriteLine("Insira o Nome do Funcionario");
        Pessoa = Console.ReadLine();
        Console.WriteLine("Insira o Salario do Funcionario");
        Salario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Visualizar quanto o funcionario ganha por Hora - digite 1");
        Console.WriteLine("Visualizar quanto o funcionario ganha por Dia - digite 2");
        Console.WriteLine("Visualizar quanto o funcionario ganha por Mes - digite 3");
        Console.WriteLine("Visualizar quanto o funcionario ganha por Ano - digita 4");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine($"Valor que {Pessoa} recebe por hora: " + (Salario / 220));
                break;
            case "2":
                Console.WriteLine($"Valor que {Pessoa} recebe por dia: " + (Salario / 30));
                break;
            case "3":
                Console.WriteLine($"Valor que {Pessoa} recebe por mês: " + Salario);
                break;
            case "4":
                Console.WriteLine($"Valor que {Pessoa} recebe por ano: " + (Salario * 12));
                break;
        }
    }
}