using Microsoft.EntityFrameworkCore;
public static class ClienteApi
{
    public static void MapClienteApi(this WebApplication app)
    {
        var group = app.MapGroup("/clientes");

        group.MapGet("/", async (BarbeariaContext db) =>
        {
            return await db.Clientes.ToListAsync();
        });

        group.MapPost("/", async (Cliente cliente, BarbeariaContext db) =>
        {
            db.Clientes.Add(cliente);
            await db.SaveChangesAsync();
            return Results.Created
            ($"/clientes/{cliente.IdCliente}", cliente);
        });

        group.MapPut("/{id}", async (int id, Cliente clienteAlterado, BarbeariaContext db) =>
        {
            var cliente = await db.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return Results.NotFound();
            }

            cliente.Nome = clienteAlterado.Nome;
            cliente.CPF = clienteAlterado.CPF;
            cliente.Telefone = clienteAlterado.Telefone;
            cliente.DataNascimento = clienteAlterado.DataNascimento;
            cliente.Email = clienteAlterado.Email;

            await db.SaveChangesAsync();
            return Results.NoContent();
        });

        group.MapDelete("/{id}", async (int id, BarbeariaContext db) =>
        {
            var cliente = await db.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return Results.NotFound();
            }

            db.Clientes.Remove(cliente);
            await db.SaveChangesAsync();
            return Results.NoContent();
        });
    }
}