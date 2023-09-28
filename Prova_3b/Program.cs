using System;
using System.ComponentModel;
using System.Net.Http.Headers;
using Prova_3b;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("CADASTRAR FUNCIPNÁRIOS");
Console.WriteLine("1-ADMINISTRATIVO");
Console.WriteLine("2-MÉDICO");
Console.WriteLine("3-SAIR");
int opcao = Convert.ToInt32(Console.ReadLine());

if(opcao == 1 )
{
     
 
    Administracao a = new Administracao("paola", "11111111111", DateOnly.Parse("2000,09,01"), "femenino", 2000.00);
    List<Administracao>listaAdministrsacao = new List<Administracao>();
    listaAdministrsacao.Add(a);
    foreach(Administracao administracao in listaAdministrsacao)
    {
        Console.WriteLine($"{administracao.Nome}, {administracao.Salario}");
    }
}

else if( opcao == 2)
{
    Medico m = new Medico("jeferson", "111111111111", "029299202020", DateOnly.Parse("2000,09,01"), "masculino", 2000.00);
    Medico m1 = new Medico("paulo", "22222222222", "3933839383939", DateOnly.Parse("2000,09,01"), "masculino", 2000.00);
    List<Medico> listaMedico = new List<Medico>().ToList();
    listaMedico.Add(m);
    listaMedico.Add(m1 );   
    foreach(Medico medico in listaMedico)
    {
        Console.WriteLine($"{medico.Nome}, {medico.Salario}");
    }
}

else
{
    Console.ReadKey();
}

Console.ReadKey();