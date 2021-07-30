using System;

namespace Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var x = new Instituicao();
            x.Nome = "Vasco Coutinho";
            x.Endereco = "Vila Velha";

            var y = new Instituicao();
            y.Nome = "Multivix";
            y.Endereco = "Serra";

            var dpalimento = new Departamento();
            dpalimento.Nome = "Cozinha";

            var dpinformatica = new Departamento();
            dpinformatica.Nome = "TI";

            var dpgeral= new Departamento();
            dpgeral.Nome = "ADM";
            x.Registrardp(dpalimento);
            x.Registrardp(dpinformatica);

            y.Registrardp(dpgeral);

            Console.WriteLine("Vasco Coutinho");
            for (int i =0; i < x.Obeterquatdps(); i++)
            {
                Console.WriteLine($"==> {x.Departamentos[i].Nome}");
            }
            Console.WriteLine("Multivix");
            for (int i = 0; i < y.Obeterquatdps(); i++)
            {
                Console.WriteLine($"==> {y.Departamentos[i].Nome}");
            }
            Console.Write("Pressione	qualquer	tecla	para	continuar");
            Console.ReadKey();
        }
        
    }
}
