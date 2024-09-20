using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CorridaComCachorros
{
    public class Apostador
    {
        public string Nome {  get; set; }
        public double Saldo { get; set; }


        public void CriarApostador(BancoDeDados bancoDeDados, int id)
        {
            bool jaExiste = false;
            do
            {
                Apostador apostador = new Apostador();
                Console.WriteLine("Informe o nome do apostador " + id + ":");
                apostador.Nome = Console.ReadLine();

                apostador.Saldo = 20;

                Console.WriteLine(" ");

                bancoDeDados.Apostadores.Add(apostador);

               foreach (Apostador apostador1 in bancoDeDados.Apostadores) 
               {
                   if (apostador1.Nome == apostador.Nome)
                   {
                       jaExiste = true;
                   }
               }
                
            } 
            while (jaExiste = true);







        }

        public void Apostar(BancoDeDados bancoDeDados)
        {

            string cachorroDesejado;

            foreach (Cachorro cachorro in bancoDeDados.Cachorros)
            {
                Aposta apostaRespectiva = new Aposta();
                apostaRespectiva.Cachorro = cachorro;

                bancoDeDados.Apostas.Add(apostaRespectiva);

            }

            foreach (Apostador apostador in bancoDeDados.Apostadores)
            {
                Console.WriteLine("Em qual cachorro o apostador " + apostador + " ira apostar? ");

                foreach(Cachorro cachorro in bancoDeDados.Cachorros) 
                {
                    Console.WriteLine(" - " + cachorro.Nome);
                }
                cachorroDesejado = Console.ReadLine().ToLower();

                
                Console.WriteLine("Quanto o apostador " + apostador.Nome + " deseja apostar? ");
                double valorDesejado = Convert.ToDouble(Console.ReadLine());


                bool cachorroExiste = true;
                foreach (Aposta aposta in bancoDeDados.Apostas)
                {
                    
                        if (cachorroDesejado == aposta.Cachorro.Nome.ToLower())
                        {
                            cachorroExiste = true;
                            aposta.Valor += valorDesejado;
                        }

                        else
                        {
                            cachorroExiste = false;
                        }
                    
                    
                }

                if (cachorroExiste = false) 
                {
                    Console.WriteLine("O Cachorro não existe ");
                }
            }
        }
    }
}
