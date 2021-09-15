namespace provaProgAvan
{
    public class nacional:carro
    {
        public nacional(string n,string c,string m,double v,int a)
        {
            nome = n;
            cor = c;
            modelo = m;
            anoFab = a;
        }
        public nacional()
        {
            nome = "Lamborghini";
            cor = "Verde";
            modelo = "Gallardo";
            anoFab = 2018;
        }

        public override void definirValorVeiculo(double CustoFixo)
        {
            valor = (CustoFixo*1.5) + (0.2*CustoFixo) + (CustoFixo/10);
        }
    }
}