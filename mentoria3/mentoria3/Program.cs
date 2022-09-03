using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mentoria2608
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Programa();   

        }

        public static void Programa()
        {
            string Pessoa;
            double Salario;
            string Escolha;
            Console.WriteLine("Bem Vindo ao seu cauculador de salario");
            //Rebceber dados do Nome
            Console.WriteLine("Insira o Nome do Funcionario");
            Pessoa = Console.ReadLine();
            //Receber o salario
            Console.WriteLine("Insira o Salario do Funcionario");
            Salario = Convert.ToDouble(Console.ReadLine());
            //Apresentar Menu
            Option();
            //Escolher comando
            switch (Console.ReadLine())
            {
                case "1":
                    HoraTrabalho(Salario);
                    break;
                case "2":
                    DiaTrabalho(Salario);
                    break;
                case "3":
                    MesTrabalho(Salario);
                    break;
                case "4":
                    AnoTrabalho(Salario);
                    break;
            }

            Console.WriteLine("Deseja realizar outra consulta? digite SIM para continuar Não Para sair");
            Escolha = (Console.ReadLine().ToLower());

            if (Escolha == "sim")
            {
                Console.Clear();
                Programa();
            }
        }
        public static void Option()
        {
            Console.WriteLine("Visualizar quanto o funcionario ganha por Hora - digite 1");
            Console.WriteLine("Visualizar quanto o funcionario ganha por Dia - digite 2");
            Console.WriteLine("Visualizar quanto o funcionario ganha por Mes - digite 3");
            Console.WriteLine("Visualizar quanto o funcionario ganha por Ano - digita 4");
        }


        public static void HoraTrabalho(double Data)
        {
            Console.WriteLine("Valor que o funcionario recebe por hora: " + (Data / 220));
        }

        public static void DiaTrabalho(double Data)
        {
            Console.WriteLine("Valor que o funiconario recebe por dia: " + (Data / 30));
        }

        public static void MesTrabalho(double Data)
        {
            Console.WriteLine("Valor que o funcionario recebe por mês: " + Data);
        }

        public static void AnoTrabalho(double Data)
        {
            Console.WriteLine("Valor que recebe por ano: " + (Data * 12));
        }
    }
}