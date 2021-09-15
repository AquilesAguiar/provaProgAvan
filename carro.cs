using System;
namespace provaProgAvan
{
    public abstract class carro
    {
        public string nome { get; protected set; }
        public string cor { get; protected set; }
        public string modelo { get; protected set; }
        public double valor { get; protected set; }
        public int anoFab { get; protected set; }

        public void reformar (bool pintar,bool trocarRoda) 
        {
            if(pintar == true)
            {
                Console.WriteLine("Pintando ........ Pitura feita");
            }
            if(trocarRoda == true)
            {
                Console.WriteLine("Trocando Roda ........ Roda trocada");
            }
        }
        public void reformar (bool pintar,bool trocarRoda,bool trocarAscento) 
        {
            if(pintar == true)
            {
                Console.WriteLine("Pintando ........ Pitura feita");
            }
            if(trocarRoda == true)
            {
                Console.WriteLine("Trocando Roda ........ Roda trocada");
            }
            if(trocarAscento == true)
            {
                Console.WriteLine("Trocando ascento ........ Ascento Trocado");
            }
        }
        public abstract void definirValorVeiculo(double CustoFixo);
        
    }
}