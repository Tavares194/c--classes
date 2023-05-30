namespace Classes;

public class Ingles : Gastos
{
    public Ingles(string cliente, decimal valorInicial) : base(cliente, valorInicial){}

    public override void MargemDeSeguranca()
    {
        decimal margem = ValorAcumulado * 0.03m;
        EfetuarTransacao(margem, DateTime.Now, "Margem de segurança para Inglês");
    }
}