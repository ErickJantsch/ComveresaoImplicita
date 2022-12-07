using System;
using System.Globalization;


namespace Aula2__ConversaoInplicitaCasting
{
    class Program
    {
        static void Main(string[] args)
        {


            //Em um novo programa, inicie as seguintes variaveis:


            string Produto = "computador";
            string Produto2 = "Mesa de Escritorio";

            byte Idade = 30;
            int codigo = 5290;
            char genero = 'm';
            
            double preco1 = 2100.00;
            double preco2 = 650.50;
            double media = 53.234567;



            string txt = $"Produto:\n" +
                         $"{Produto} Cujo o preco £ e  {preco1} \n" +
                         $"{ Produto2} Cujo o preco £ e  {preco2} \n\n" +
                         $"Registro {Idade} anos de idade, codigo {codigo} e genero {genero}\n\n" +
                         $"Media com oito casas decimais: {media}";

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(txt);
            Console.WriteLine($"Arredondando(tres casas decimais):{ media.ToString("f3")}");
            Console.WriteLine($"Separador decimal invariante culture:{media.ToString("f3", CultureInfo.GetCultureInfo("EN-UK"))}");
            Console.WriteLine("------------------------------------------------");





















        }
    }
}
