using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoria2608
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string Pessoa;
            double Salario;
            Console.WriteLine("Bem Vindo ao seu cauculador de salario");
            //Rebceber dados do Nome
            Console.WriteLine("Insira o Nome do Funcionario");
            Pessoa = Console.ReadLine();
            //Receber o salario
            Console.WriteLine("Insira o Salario do Funcionario");
            Salario = Convert.ToDouble(Console.ReadLine());
            //Apresentar Menu
            option();
            //Escolher comando
            switch (Console.ReadLine())
            {
                case "1":
                    horaTrabalho(Salario);
                    break;
                case "2":
                    diaTrabalho(Salario);
                    break;
                case "3":
                    mesTrabalho(Salario);
                    break;
                case "4":
                    anoTrabalho(Salario);
                    break;

            }
            Console.ReadLine();
        }

        public static void option()
        {
            Console.WriteLine("Visualizar quanto o funcionario ganha por Hora - digite 1");
            Console.WriteLine("Visualizar quanto o funcionario ganha por Dia - digite 2");
            Console.WriteLine("Visualizar quanto o funcionario ganha por Mes - digite 3");
            Console.WriteLine("Visualizar quanto o funcionario ganha por Ano - digita 4");
        }


        public static void horaTrabalho( double Data)
            {
                Console.WriteLine("Valor que o funcionario recebe por hora: " + (Data / 220));                
            }

        public static void diaTrabalho(double Data)
            {
                Console.WriteLine("Valor que o funiconario recebe por dia: " + (Data / 30));                
            }

        public static void mesTrabalho(double Data)
            {
                Console.WriteLine("Valor que o funcionario recebe por mês: " + Data);                
            }

        public static void anoTrabalho(double Data)
            {
                Console.WriteLine("Valor que recebe por ano: " + (Data * 12));                
            }


        
    }
}
