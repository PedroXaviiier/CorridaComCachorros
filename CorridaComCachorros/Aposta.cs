using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaComCachorros
{
    public class Aposta
    {
        public double Valor { get; set; }
        public List<Apostador> Apostadores { get; set; }

        public BancoDeDados bancoDeDados { get; set; }

        public Cachorro Cachorro { get; set; }

        public bool ganhou(Aposta aposta)
        {
            bool final = false;

            
                aposta.Cachorro.Correr(aposta.Cachorro);

                if (aposta.Cachorro.DistanciaPercorrida >= 100)
                {
                    foreach (Apostador apostador in aposta.Apostadores)
                    {
                        apostador.Saldo += aposta.Valor / aposta.Apostadores.Count;
                    }

                    final = true;
                }

                else
                {
                    final = false;
                }

            
            return final;
        }
    }
}
