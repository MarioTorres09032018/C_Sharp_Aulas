using System;
using System.Data.SqlTypes;
using System.Globalization;

namespace Aula
{
    class Program
    {
        static void Main()
        {
            //-----------------------------------------------------------------PESSOA------------------------------------------------------------------------------------------------//
            Escrever("*Bem vindo ao sistema de cadastro BASE DE PESSOAL");

            Escrever(" Escolha uma opção");
            Escrever("");
            Escrever("1 - Base de Pessoal");
            Escrever("2 - Pessoa Juridica");
            Escrever("3 - Pessoa Fisica");
            Console.ReadLine();

            string escolha = "1 - Base de Pessoal";
            bool digitado=true;
            

            while (escolha != "1")
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE BASE DE PESSOAL");
                escolha = Console.ReadLine();
            }
            Console.Clear();

            if (escolha == "1")
            {
                Escrever("Digite seu nome.....:");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome.....:");
                string sobrenome = Console.ReadLine();

                Escrever("Digite sua Data Nascimento.....:");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Console.Clear();

                Escrever("Digite a cor dos seus olhos.....:");
                string olhos = Console.ReadLine();

                Pessoa pes = new Pessoa(n, sobrenome, dtnascimento, olhos);

                pes.Gravar();

            }
            else if (escolha == "2")
            {
                Escrever("OPÇÃO NÃO CORRESPONDE A BASE DE PESSOAL");

            }
            else if (escolha == "3")
            {
                Escrever("OPÇÃO NÃO CORRESPONDE A BASE DE PESSOAL");
            }

            {
                Escrever("--------------------------------------------------");
            }
            //-------------------------------------------------------------------PESSOA JURIDICA-------------------------------------------------------------------------------------//
            Escrever("\n*Bem vindo ao sistema de cadastro de PESSOA JURÍDICA");

            Escrever(" Escolha uma opção");
            Escrever("");
            Escrever("1 - Base de Pessoal");
            Escrever("2 - Pessoa Juridica");
            Escrever("3 - Pessoa Fisica");
            Console.ReadLine();

            string escolha2 = "2 - Pessoa Juridica";

            while (escolha2 != "2")
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE PESSOA JURÍDICA");
                escolha2 = Console.ReadLine();
            }
            Console.Clear();

            if (escolha2 == "2")
            {
                Escrever("Digite seu nome.....:");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome.....:");
                string sobrenome = Console.ReadLine();

                Escrever("Digite seu CNPJ.....:");
                string CNPJ = Console.ReadLine();

                Escrever("Digite sua Data Nascimento.....:");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Console.Clear();

                Escrever("Digite a cor dos seus olhos.....:");
                string olhos = Console.ReadLine();

                PessoaJuridica pj = new PessoaJuridica(n, sobrenome, CNPJ, dtnascimento, olhos);

                pj.Gravar();

            }
            else if (escolha2 == "1")
            {
                Escrever("OPÇÃO NÃO CORRESPONDE A PESSOA JURÍDICA");

            }
            else if (escolha2 == "3")
            {
                Escrever("OPÇÃO NÃO CORRESPONDE A PESSOA JURÍDICA");
            }

            {
                Escrever("--------------------------------------------------");
            }
            //---------------------------------------------------------------------PESSOA FISICA------------------------------------------------------------------------------------//
            Escrever("\n*Bem vindo ao sistema de cadastro de PESSOA FÍSICA");

            Escrever(" Escolha uma opção");
            Escrever("");
            Escrever("1 - Base de Pessoal");
            Escrever("2 - Pessoa Juridica");
            Escrever("3 - Pessoa Fisica");
            Console.ReadLine();

            string escolha3 = "3 - Pessoa Fisica";

            while (escolha3 != "3")
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE PESSOA FÍSICA");
                escolha3 = Console.ReadLine();
            }
            Console.Clear();

            if (escolha3 == "3")
            {
                Escrever("Digite seu nome.....:");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome.....:");
                string sobrenome = Console.ReadLine();

                Escrever("Digite seu CPF.....:");
                string cpf = Console.ReadLine();

                Escrever("Digite seu RG.....:");
                string rg = Console.ReadLine();

                Escrever("Digite sua Data Nascimento.....:");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Console.Clear();

                Escrever("Digite a cor dos seus olhos.....:");
                string olhos = Console.ReadLine();

                PessoaFisica pf = new PessoaFisica(n, sobrenome, cpf, rg, dtnascimento, olhos);

                pf.Gravar();

            }
            else if (escolha3 == "1")
            {
                Escrever("OPÇÃO NÃO CORRESPONDE A PESSOA FÍSICA");

            }
            else if (escolha3 == "2")
            {
                Escrever("OPÇÃO NÃO CORRESPONDE A PESSOA FÍSICA");
            }

            {
                Escrever("--------------------------------------------------");
            }



            static void Escrever(string mensagemParaPrintarNaTela)
            {
                Console.WriteLine(mensagemParaPrintarNaTela);

            }
        }

    }
}
