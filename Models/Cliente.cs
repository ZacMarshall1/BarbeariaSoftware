using System.ComponentModel.DataAnnotations;
public class Cliente
{
    [Key]
    public int IdCliente { get; set; }
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public string? Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
    public string? Email { get; set; }

    public override string ToString()
    {
        return $"Id: {IdCliente}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}";
    }
    
}
