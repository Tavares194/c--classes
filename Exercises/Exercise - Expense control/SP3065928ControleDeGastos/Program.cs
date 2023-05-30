using Classes;
var conta1 = new Ingles("Tavares", 0);
conta1.EfetuarTransacao(360, DateTime.Now, "Mensalidade");
conta1.EfetuarTransacao(250, DateTime.Now, "Material");
conta1.MargemDeSeguranca();
Console.WriteLine(conta1.HistoricoDeGastos());

var conta2 = new Futebol("Tavares", 0);
conta2.EfetuarTransacao(100, DateTime.Now, "Chuteira");
conta2.EfetuarTransacao(40, DateTime.Now, "Bola");
conta2.MargemDeSeguranca();
Console.WriteLine(conta2.HistoricoDeGastos());

var conta3 = new Alimentacao("Tavares", 0);
conta3.EfetuarTransacao(20, DateTime.Now, "Café");
conta3.EfetuarTransacao(50, DateTime.Now, "Compra de mantimentos");
conta3.MargemDeSeguranca();
Console.WriteLine(conta3.HistoricoDeGastos());

var conta4 = new Vestuario("Tavares", 0);
conta4.EfetuarTransacao(100, DateTime.Now, "Agasalho");
conta4.EfetuarTransacao(50, DateTime.Now, "Calça");
conta4.EfetuarTransacao(250, DateTime.Now, "Terno");
conta4.MargemDeSeguranca();
Console.WriteLine(conta4.HistoricoDeGastos());