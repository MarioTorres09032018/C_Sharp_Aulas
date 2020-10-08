using Aula;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SalarioBase_Comissao  
{
    public class CargoVendedor:Pessoa
    {
        static void Main()
        {
            double QtdVendas = 0;
            double mes;
            double salario=1.200;
            double comissao = 0.1;
            
            mes= QtdVendas / salario * comissao;

            Console.WriteLine("Informe o numero de dias trabalhados");
            mes = int.Parse(Console.ReadLine());
        }
        
        public CargoVendedor(string nome, string sobrenome, string Cargo, DateTime dataNascimento, string cordosolhos)

                            : base(nome, sobrenome, dataNascimento, cordosolhos)

        {
            Vendedor = Cargo;
        }
        public string Vendedor { get; set; }

        

    }
}
