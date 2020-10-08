using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;

namespace Aula
{
    class Program
    {
        static void Main()
        {
            MenuInicial();

            string escolha = string.Empty;

            escolha = CapturarEscolhaDoUsuario(ref escolha);

            do
            {
                if ("4".Equals(escolha)) break;

                EfetuarAcaoDeAcordoComEscolha(escolha);

                MenuInicial();
                escolha = CapturarEscolhaDoUsuario(ref escolha);

            } while (escolha != "4");

            FinalizaAplicacao();

        }

        private static void FinalizaAplicacao()
        {
            Console.WriteLine("Aplicação sendo encerrada, digite uma tecla para finalizar.");
            Console.ReadKey();
        }

        private static void MenuInicial()
        {
            //MenuInicial
            Escrever("\n*Bem vindo ao sistema de cadastro de PESSOAL");
            Escrever("");
            Escrever("1-Base de Pessoal");
            Escrever("2-Pessoa Juridica");
            Escrever("3-Pessoa Fisica");
            Escrever("4-Sair");
            Escrever("5-Carregar por Nome");
            Escrever("");
            Escrever("Escolha uma opção:");
        }

        private static void EfetuarAcaoDeAcordoComEscolha(string escolha)
        {
            // string.Empty = ""
            string n = string.Empty;
            string sobrenome = string.Empty;
            DateTime dtnascimento = DateTime.MinValue;
            int dia = 0;
            int mes = 0;
            int ano = 0;
            string cordosolhos = string.Empty;
            string rg = string.Empty;
            string cpf = string.Empty;
            string cnpj = string.Empty;
            bool pesquisa = false;

            switch (escolha)
            {
                case "1":
                    PerguntasBasicas(out n, out sobrenome, out dtnascimento, out dia, out mes, out ano, out cordosolhos);

                    Pessoa pes = new Pessoa(n, sobrenome, dtnascimento, cordosolhos);

                    pes.Gravar();

                    break;

                case "2":
                    PerguntasBasicas(out n, out sobrenome, out dtnascimento, out dia, out mes, out ano, out cordosolhos);

                    Escrever("Digite seu CNPJ.....:");
                    cnpj = Console.ReadLine();

                    PessoaJuridica pj = new PessoaJuridica(n, sobrenome, cnpj, dtnascimento, cordosolhos);

                    pj.Gravar();
                    break;
                case "3":
                    PerguntasBasicas(out n, out sobrenome, out dtnascimento, out dia, out mes, out ano, out cordosolhos);

                    Escrever("Digite seu CPF.....:");
                    cpf = Console.ReadLine();

                    Escrever("Digite seu RG.....:");
                    rg = Console.ReadLine();

                    PessoaFisica pf = new PessoaFisica(n, sobrenome, cpf, rg, dtnascimento, cordosolhos);

                    pf.Gravar();

                    break;
                case "5":
                    pesquisa = true;

                    Console.WriteLine("Digite o nome da pessoa para consulta");
                    string nome = Console.ReadLine();
                    nome = nome.ToUpper();

                    string pessoaEncontrada = Pessoa.CarregarDadosArquivo();
                    string[] pessoas = pessoaEncontrada.Split("\n");

                    for (int i = 0; i < pessoas.Length; i++)
                    {
                        string registropessoa = pessoas[i];
                        registropessoa = registropessoa.ToUpper();

                        if (registropessoa.Contains(nome))
                        {
                            Console.WriteLine("Encontrado o registro:");
                            Console.WriteLine(registropessoa);
                        }
                    }


                    break;
                default:
                    Console.WriteLine("Função não implementada");
                    break;
            }

            if (pesquisa)
            {
                Escrever("Pesquisa realizada com sucesso.");
            }
            else
            {
                Escrever("Cadastro Realizado com sucesso.");
            }
        }

        private static void PerguntasBasicas(out string n, out string sobrenome, out DateTime dtnascimento, out int dia, out int mes, out int ano, out string cordosolhos)
        {
            Escrever("Digite seu nome.....:");
            n = Console.ReadLine();

            Escrever("Digite seu sobrenome.....:");
            sobrenome = Console.ReadLine();

            Escrever("Digite o dia do seu nascimento.....:");
            dia = Convert.ToInt16(Console.ReadLine());

            Escrever("Digite o mês do seu nascimento.....:");
            mes = Convert.ToInt16(Console.ReadLine());

            Escrever("Digite o ano do seu nascimento.....:");
            ano = Convert.ToInt16(Console.ReadLine());

            dtnascimento = new DateTime(ano, mes, dia);

            Escrever("Digite a cor dos seus olhos.....:");
            cordosolhos = Console.ReadLine();
        }

        private static string CapturarEscolhaDoUsuario(ref string escolha)
        {
            escolha = Console.ReadLine();

            while (escolha != "1" && escolha != "2" && escolha != "3" && escolha != "4" && escolha != "5")
            {
                Console.WriteLine("Digite um valor válido. Ex.: 1,2,3,4,5.");
                escolha = Console.ReadLine();
            }

            return escolha;
        }

        private static void Escrever(string mensagemParaPrintarNaTela)
        {
            Console.WriteLine(mensagemParaPrintarNaTela);
        }
    }
}




