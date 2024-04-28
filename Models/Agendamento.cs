public class Agendamento
{
    public int IdAgendamento { get; set; }
    public int IdCliente { get; set; }
    public int IdServico { get; set; }
    public int IdFuncionario { get; set; }
    public DateTime DataHoraAgendamento { get; set; }
    public string? Observacao { get; set; }
}
