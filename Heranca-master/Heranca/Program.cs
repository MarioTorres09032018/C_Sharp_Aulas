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

            string escolha = "1";
            string digitado;
            int tentativas = 0;
            
            





            do        //SE DIGITAR A OPÇÃO ERRADA O "do" IRÁ EXECUTAR O CONTEÚDO DO BLOCO SEGUINTE ATÉ QUE "digitado" SEJA CORRESPONDENTE A "escolha 1".
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE PESSOA:");
                digitado = Console.ReadLine();
                tentativas++;

            } while (escolha != digitado);
            Console.Clear();

            if (escolha == "1")

            {
                Escrever("Digite seu nome.....:");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome.....:");
                string sobrenome = Console.ReadLine();
                //--------------------------------------------------------------------------------------------------------------------------------//        



                Escrever("Digite sua Data Nascimento.....:");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                //while (digitado != dtnascimento) ;
                Console.Clear();

                Console.WriteLine("DATA INVALIDA");
                 




                //----------------------------------------------------------------------------------------------------------------------------------//

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
            Escrever("1 - Pessoa");
            Escrever("2 - Pessoa Juridica");
            Escrever("3 - Pessoa Fisica");

            Console.ReadLine();

            string escolha2 = "2";
            string digitado2;
            int tentativas2 = 0;
            do        //SE DIGITAR A OPÇÃO ERRADA O "do" IRÁ EXECUTAR O CONTEÚDO DO BLOCO SEGUINTE ATÉ QUE "digitado2" SEJA CORRESPONDENTE A "escolha 2".
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE PESSOA:");
                digitado2 = Console.ReadLine();
                tentativas2++;
            } while (escolha2 != digitado2);
            Console.Clear();

            if (escolha2 == "2")
            {
                Escrever("Digite seu nome.....:");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome.....:");
                string sobrenome = Console.ReadLine();

                Escrever("Digite seu Data Nascimento.....:");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Escrever("Digite seu CNPJ.....:");
                string cnpj = Console.ReadLine();

                Escrever("Digite a cor dos seus olhos.....:");
                string olhos = Console.ReadLine();

                PessoaJuridica pj = new PessoaJuridica(n, sobrenome, dtnascimento, cnpj, olhos);

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
                Escrever("------------------------------------------------");
            }
            //---------------------------------------------------------------------PESSOA FISICA------------------------------------------------------------------------------------//
            Escrever("\n*Bem vindo ao sistema de cadastro de PESSOA FÍSICA");

            Escrever(" Escolha uma opção");
            Escrever("");
            Escrever("1 - Pessoa");
            Escrever("2 - Pessoa Juridica");
            Escrever("3 - Pessoa Fisica");

            Console.ReadLine();

            string escolha3 = "3";
            string digitado3;
            int tentativas3 = 0;
            do        //SE DIGITAR A OPÇÃO ERRADA O "do" IRÁ EXECUTAR O CONTEÚDO DO BLOCO SEGUINTE ATÉ QUE "digitado3" SEJA CORRESPONDENTE A "escolha 3".
            {
                Console.WriteLine("OPÇÃO DIGITADA INVÁLIDA AO TIPO DE PESSOA:");
                digitado3 = Console.ReadLine();
                tentativas3++;
            } while (escolha3 != digitado3);
            Console.Clear();

            if (escolha3 == "3")
            {
                Escrever("Digite seu nome");
                string n = Console.ReadLine();

                Escrever("Digite seu sobrenome");
                string sobrenome = Console.ReadLine();

                Escrever("Digite seu Data Nascimento");
                DateTime dtnascimento = Convert.ToDateTime(Console.ReadLine());

                Escrever("Digite seu CPF");
                string cpf = Console.ReadLine();

                Escrever("Digite seu RG");
                string rg = Console.ReadLine();

                Escrever("Digite a cor dos seus olhos");
                string olhos = Console.ReadLine();

                PessoaFisica pf = new PessoaFisica(n, sobrenome, dtnascimento, cpf, rg, olhos);

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
                Escrever("------------------------------------------------");
            }

        }
        
        static void Escrever(string mensagemParaPrintarNaTela)
        {
            Console.WriteLine(mensagemParaPrintarNaTela);

        }
    }

}
