namespace provaProgAvan
{
    public class internacional:carro
    {
        public internacional(string n,string c,string m,double v,int a)
        {
            nome = n;
            cor = c;
            modelo = m;
            anoFab = a;
        }
        public internacional()
        {
            nome = "Lamborghini";
            cor = "Verde";
            modelo = "Gallardo";
            anoFab = 2018;
        }

        public override void definirValorVeiculo(double CustoFixo)
        {
            valor = (CustoFixo *3.0) + (0.6*CustoFixo) + (CustoFixo/5);
        }
    }
}