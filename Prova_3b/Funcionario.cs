using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3b
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricfula { get; set; }
        public DateOnly dataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }


        public Funcionario(string nome, string cpf, string matricfula, DateOnly dataN, string sexo, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Matricfula = matricfula;
            dataNascimento = dataN;
            Sexo = sexo;
            Salario = salario;
        }
    }
}
