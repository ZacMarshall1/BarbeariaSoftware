using Microsoft.EntityFrameworkCore;
public static class AgendamentoApi
{
    public static void MapAgendamentoApi(this WebApplication app)
    {
        var group = app.MapGroup("/agendamentos");

        group.MapGet("/", async (BarbeariaContext db) =>
        {
            return await db.Agendamentos.ToListAsync();
        });

        group.MapPost("/", async (Agendamento agendamento, BarbeariaContext db) =>
        {
            db.Agendamentos.Add(agendamento);
            await db.SaveChangesAsync();
            return Results.Created($"/agendamentos/{agendamento.IdAgendamento}", agendamento);
        });

        group.MapPut("/{id}", async (int id, Agendamento agendamentoAlterado, BarbeariaContext db) =>
        {
            var agendamento = await db.Agendamentos.FindAsync(id);
            if (agendamento == null)
            {
                return Results.NotFound();
            }

            agendamento.IdCliente = agendamentoAlterado.IdCliente;
            agendamento.IdServico = agendamentoAlterado.IdServico;
            agendamento.IdFuncionario = agendamentoAlterado.IdFuncionario;
            agendamento.DataHoraAgendamento = agendamentoAlterado.DataHoraAgendamento;
            agendamento.Observacao = agendamentoAlterado.Observacao;

            await db.SaveChangesAsync();
            return Results.NoContent();
        });

        group.MapDelete("/{id}", async (int id, BarbeariaContext db) =>
        {
            var agendamento = await db.Agendamentos.FindAsync(id);
            if (agendamento == null)
            {
                return Results.NotFound();
            }

            db.Agendamentos.Remove(agendamento);
            await db.SaveChangesAsync();
            return Results.NoContent();
        });
    }
}