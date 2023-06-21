namespace AV2.Models;

class Produto {
    public int CodProduto { get; set; }
    public string Descricao { get; set; }
    public decimal ValorUnitario { get; set; }

    public Produto(int codproduto, string descricao, decimal valorunitario) {
        CodProduto = codproduto;
        Descricao = descricao;
        ValorUnitario = valorunitario;
    }
}