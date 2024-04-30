using System.ComponentModel.DataAnnotations;
public class Servico
{
    [Key]
    public int IdServico { get; set; }
    public string? Nome { get; set; }
    public int Duracao { get; set; }
    public decimal Preco { get; set; }
    public string? Descricao { get; set; }

    public override string ToString()
    {
        return $"Id: {IdServico}, Nome: {Nome}, Preço: {Preco}, Duração: {Duracao}";
    }
}
