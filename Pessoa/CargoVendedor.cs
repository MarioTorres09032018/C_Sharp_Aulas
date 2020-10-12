<<<<<<< HEAD
﻿using System;
=======
﻿using Aula;
using System;
>>>>>>> 80c9b9632691aac474c766a33fcb3af843b1b3db
using System.Collections.Generic;
using System.Text;
using System.Threading;

<<<<<<< HEAD
namespace Aula
{
    public class CargoVendedor : Pessoa
    {
        public CargoVendedor(string profissao, string nome, string sobrenome, DateTime dataNascimento, string cordosolhos, double QtdVendas, double SalMes,
         double comissao, double QtdDias)

                                 : base(nome, sobrenome, dataNascimento, cordosolhos)


        {
            Cargo = profissao;
            VensdasMes = QtdVendas;
            Salariomes = SalMes;
            BonusMes= comissao;
            DiasTrabalhados = QtdDias;
        }
        public string Cargo { get; set; }
        public double Salariomes { get; set; }
        public double BonusMes { get; set; }
        public double VensdasMes { get; set; }
        public double DiasTrabalhados { get; set; }
    } 
   
}








=======
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
>>>>>>> 80c9b9632691aac474c766a33fcb3af843b1b3db
