using Microsoft.EntityFrameworkCore;
public static class ServicoApi
{
    public static void MapServicoApi(this WebApplication app)
    {
        var group = app.MapGroup("/servicos");

        group.MapGet("/", async (BarbeariaContext db) =>
        {
            return await db.Servicos.ToListAsync();
        });

        group.MapPost("/", async (Servico servico, BarbeariaContext db) =>
        {
            db.Servicos.Add(servico);
            await db.SaveChangesAsync();
            return Results.Created($"/servicos/{servico.IdServico}", servico);
        });

        group.MapPut("/{id}", async (int id, Servico servicoAlterado, BarbeariaContext db) =>
        {
            var servico = await db.Servicos.FindAsync(id);
            if (servico == null)
            {
                return Results.NotFound();
            }

            servico.Nome = servicoAlterado.Nome;
            servico.Duracao = servicoAlterado.Duracao;
            servico.Preco = servicoAlterado.Preco;
            servico.Descricao = servicoAlterado.Descricao;

            await db.SaveChangesAsync();
            return Results.NoContent();
        });

        group.MapDelete("/{id}", async (int id, BarbeariaContext db) =>
        {
            var servico = await db.Servicos.FindAsync(id);
            if (servico == null)
            {
                return Results.NotFound();
            }

            db.Servicos.Remove(servico);
            await db.SaveChangesAsync();
            return Results.NoContent();
        });
    }
}