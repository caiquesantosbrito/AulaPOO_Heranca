using System;
using Heranca.Classes;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();

            pf.cpf = "359.082.438-76";   
            pf.nome = "Caique";   

            PessoaJuridica pj = new PessoaJuridica();
            
            pj.cnpj= "12.345.678/0001-30";
           
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine( pf.darBoasVindas(pf.nome));
            Console.WriteLine(pj.IsCNPJ (pj.cnpj));
            Console.WriteLine (pf.IsCPF (pf.cpf));
            Console.ResetColor();    
        }
    }
}
