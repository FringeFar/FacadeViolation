using System;

namespace FacadeViolation.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //SubsystemA
            Carteira carteira = new Carteira();



            //SubsystemB

            Pessoa pessoa = new Pessoa();

            // Sacar Dinheiro

            pessoa.Ir("caixa eletrônico");

            carteira.Abrir();

            carteira.PegarCartao("débito");

            pessoa.PassarCartao();

            pessoa.DigitarSenha();

            pessoa.PegarDinheiro();

            carteira.GuardarCartao();

            carteira.Guardar("bolso");

            pessoa.Ir("casa");

            Console.ReadKey();
        }
    }
}
