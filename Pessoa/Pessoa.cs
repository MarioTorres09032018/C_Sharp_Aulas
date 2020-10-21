using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
<<<<<<< HEAD
=======
using System.Text;
>>>>>>> e2983ba3e6fdcb6b8c2eb092ad2a8974026f9ca5
using System.Text.Json.Serialization;

namespace Aula
{
    public class Pessoa
    {
        const string PATHFILE = @"c:\CADASTRO\CadastroUsuario.txt";
        const string PASTA = @"c:\CADASTRO";

        public Pessoa(string nome, string sobrenome, DateTime dataNascimento, string cordosolhos)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            CorDosOlhos = cordosolhos;
        }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string CorDosOlhos { get; private set; }
        public int Idade
        {
            get
            {
                return DateTime.Now.Year - DataNascimento.Year;
            }

        }
        public void Gravar()
        {

            string dadoscarregados = CarregarDadosArquivo();
            
            if (!Directory.Exists(PASTA))
            {
                Directory.CreateDirectory(PASTA);
            }

<<<<<<< HEAD
=======
            Console.WriteLine(File.Exists(PATHFILE));
            File.WriteAllText(PATHFILE, "CadastroUsuario");
            Console.WriteLine(File.Exists(PATHFILE));
            Console.ReadKey(true);

>>>>>>> e2983ba3e6fdcb6b8c2eb092ad2a8974026f9ca5
            //salva em um arquivo de txt
            File.WriteAllText(PATHFILE, JsonConvert.SerializeObject(this) + "\n" +  dadoscarregados);
            
        }
<<<<<<< HEAD

        public static string CarregarDadosArquivo()
        {
            return File.ReadAllText(PATHFILE);
=======
        
        public static string CarregarDadosArquivo()
        
        {
            return File.ReadAllText(PATHFILE); //return dando problema. Não cria mais a pasta nem salva arquivo, só se criar manualmente.
>>>>>>> e2983ba3e6fdcb6b8c2eb092ad2a8974026f9ca5
        }
    }
}

