namespace Classes;

public class Alimentacao : Gastos
{
    private readonly decimal _bonificacao = -50m;

    public Alimentacao(string cliente, decimal valorInicial, decimal bonusalimentacao = -50) : base(cliente, valorInicial)
    => _bonificacao = bonusalimentacao;

    public override void MargemDeSeguranca()
{
    decimal margem = ValorAcumulado * 0.01m;
    EfetuarTransacao(margem, DateTime.Now, "Margem de segurança para Alimentação");
    if (_bonificacao != 0)
    {
        EfetuarTransacao(_bonificacao, DateTime.Now, "Bonus para alimentação");
    }
}
}