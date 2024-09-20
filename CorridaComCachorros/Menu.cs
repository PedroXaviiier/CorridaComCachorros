using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CorridaComCachorros
{
    public class Menu
    {
        public BancoDeDados IniciarMenu()
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            string opcao;
            Apostador apostador = new Apostador();
            int i;


            for (i = 0; i < 4; i++)
            {
                
                apostador.CriarApostador(bancoDeDados, i);
            }

            Console.WriteLine("deseja criar mais apostadores? S/N");
            opcao = Console.ReadLine().ToLower();

            while (opcao == "S".ToLower()) 
            {
                apostador.CriarApostador(bancoDeDados, i);

                Console.WriteLine("deseja criar mais apostadores? S/N");
                opcao = Console.ReadLine().ToLower();
            }
            


            for (i = 0; i < 5; i++)
            {
                Cachorro cachorro = new Cachorro();
                cachorro.CriarCachorro(bancoDeDados, i);
            }

            Console.WriteLine("deseja criar mais Cachorros? S/N");
            opcao = Console.ReadLine().ToLower();

            while (opcao == "S".ToLower())
            {
                Cachorro cachorro = new Cachorro();
                cachorro.CriarCachorro(bancoDeDados, i);

                Console.WriteLine("deseja criar mais Cachorros? S/N");
                opcao = Console.ReadLine().ToLower();
            }
            

            apostador.Apostar(bancoDeDados);

            return bancoDeDados;
        }


        public void IniciarCorrida(BancoDeDados bancoDeDados) 
        {

            bool fim = false;

            do
            {
                foreach (Aposta aposta in bancoDeDados.Apostas)
                {
                
                    fim = aposta.ganhou(aposta);
                }
                
            }
            while (fim == false);
        }
    }
}
