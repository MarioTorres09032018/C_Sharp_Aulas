using System;
using System.IO;
using System.Text.Json.Serialization;

namespace Aula
{
    public class PessoaFisica : Pessoa 
    {
        public PessoaFisica(string nome, string sobrenome, string cpf, string rg, DateTime dataNascimento, string cordosolhos)

                            : base(nome, sobrenome, dataNascimento,cordosolhos)
        {
            CPF = cpf;
            RG = rg;
        }
<<<<<<< HEAD
        public string CPF { get; set; }
=======
        public string CPF { get; set; } 
>>>>>>> e2983ba3e6fdcb6b8c2eb092ad2a8974026f9ca5

        public string RG { get; set; }

    }
}
