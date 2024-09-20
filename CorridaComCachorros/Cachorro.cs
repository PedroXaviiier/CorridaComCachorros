namespace CorridaComCachorros
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public int[] Movimentos;
        public int DistanciaPercorrida;

        public void Correr(Cachorro cachorro) 
        {
            Random tipoDePassos = new Random();
            tipoDePassos.Next(2);

            if (Convert.ToInt32(tipoDePassos) == 0) 
             {
                DistanciaPercorrida += cachorro.Movimentos[0];
             }

            else if(Convert.ToInt32(tipoDePassos) == 1)
             {
                DistanciaPercorrida += cachorro.Movimentos[1];
             }
         }


        

        public void CriarCachorro(BancoDeDados bancoDeDados, int id)
        {
            Cachorro cachorro = new Cachorro();
            Console.WriteLine("Informe o nome do cachorro " + id + ":");
            cachorro.Nome = Console.ReadLine();

            Console.WriteLine(" ");

            Random random = new Random();


            switch (random.Next(4))
            {
                case 0:
                    cachorro.Movimentos = new int[] { 0, 70 };
                    break;

                case 1:
                    cachorro.Movimentos = new int[] { 30, 50 };
                    break;

                case 2:
                    cachorro.Movimentos = new int[] { 20, 40 };
                    break;

                case 3:
                    cachorro.Movimentos = new int[] { 10, 60 };
                    break;
            }

            bancoDeDados.Cachorros.Add(cachorro);
        }
    }
}
  