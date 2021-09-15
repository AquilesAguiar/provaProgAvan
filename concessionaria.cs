using System;
using System.Collections.Generic;
namespace provaProgAvan
{
    public class concessionaria
    {
        private string localizacao;
        private string gerente;
        private int anoFundacao;
        protected List<carro> carrosDisponiveis = new List<carro>();
        
        public string getLocalizacao()
        {
            return localizacao;
        }
        public void setLocalizacao(string l){
            localizacao = l;
        }
        public string getGerente()
        {
            return gerente;
        }
        public void setGerente(string g){
            gerente = g;
        }
        public int getanoFundacao()
        {
            return anoFundacao;
        }
        public void setanoFundacao(int a){
            anoFundacao = a;
        }

        
        public void adicionarCarro(carro car)
        {
            carrosDisponiveis.Add(car);
            Console.WriteLine($"{car.nome} adicionado a lista");
        }
        public double calcularPortifolio(){
            double val = 0;

            for (int i = 0; i < carrosDisponiveis.Count; i++)
            {
                val += carrosDisponiveis[i].valor;
            }
            return val;
        }
    }
}