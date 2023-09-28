using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3b
{
    internal class Administracao : Funcionario
    {
      

        public Administracao(string nome, string cpf, string matricfula, DateOnly dataN, string sexo, double salario) : base(nome, cpf, matricfula, dataN, sexo, salario)
        { 

        }

        public double salario (double salario)
        {
            this.Salario = salario;
            double valeTransp = 250;
            double valeAlim = 17.00 / 100 + salario;
            double result = salario + valeTransp + valeAlim;
            return result;
        }
       
    }
}
