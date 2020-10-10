using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Aula
{
    public class CargoVendedor : Pessoa
    {
        public CargoVendedor(string profissao, string nome, string sobrenome, DateTime dataNascimento, string cordosolhos, double QtdVendas, double SalMes,
         double comissao, double QtdDias)

                                 : base(nome, sobrenome, dataNascimento, cordosolhos)


        {
            salariomes = SalMes;
            BonusMes= comissao;
            VensdasMes = QtdVendas;
            DiasTrabalhados = QtdDias;
        }
       
        public double salariomes { get; set; }
        public double BonusMes { get; set; }
        public double VensdasMes { get; set; }
        public double DiasTrabalhados { get; set; }
    } 
   
}








