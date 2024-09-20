using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaComCachorros
{
    public class BancoDeDados
    {
        public List<Aposta> Apostas {  get; set; }
        public List<Cachorro> Cachorros { get; set; }
        public List<Apostador> Apostadores { get; set; }

        public BancoDeDados() 
        {
            Apostas = new List<Aposta>();
            Cachorros = new List<Cachorro>();
            Apostadores = new List<Apostador>();
        }


    }
}
