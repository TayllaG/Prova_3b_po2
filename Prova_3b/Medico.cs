using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3b
{
    internal class Medico:Funcionario
    {
        public string Crm { get; set; }
        public double valorHoraEx { get; set; }
        public string Especialidade { get; set; }

        public Medico(string nome, string cpf, string matricfula, DateOnly dataN, string sexo, double salario, string crm, double valorHoraEx, string especialidade) : base(nome, cpf, matricfula, dataN , sexo, salario)
        {
            Crm = crm;
            this.valorHoraEx = valorHoraEx;
            Especialidade = especialidade;
        }

        public Medico(string nome, string cpf, string matricfula, DateOnly dataN, string sexo, double salario) : base(nome, cpf, matricfula, dataN, sexo, salario)
        {
        }

        public double Beneficio(double porcentagem)
        {
            porcentagem = 22;
            double soma = (porcentagem * Salario) / 100 * Salario;

            return soma;
        }
    }

    
}

