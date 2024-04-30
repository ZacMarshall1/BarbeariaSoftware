using System.ComponentModel.DataAnnotations;
public class Agendamento
{
    [Key]
    public int IdAgendamento { get; set; }
    public int IdCliente { get; set; }
    public int IdServico { get; set; }
    public int IdFuncionario { get; set; }
    public DateTime DataHoraAgendamento { get; set; }
    public string? Observacao { get; set; }

    public override string ToString()
    {
        return $"Id: {IdAgendamento}, DataHora: {DataHoraAgendamento}, Observação: {Observacao}";
    }
}
